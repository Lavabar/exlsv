import socket
import mysql.connector
from mysql.connector import Error
import random

from sklearn.linear_model import LogisticRegression as Model

HOST = 'sql11.freemysqlhosting.net'
DATABASE = 'sql11228687'
USER = 'sql11228687'
PASSWORD = 'xsgxhgnjHb'

with open("conf.txt", "r") as f1:
	ADDRESS = f1.readline()
def process(state):
    features = state.split(";")
    print(features)
    res = []

    for i in range(len(features)):
        features[i] = float(features[i])
    for i in range(11):
        features[i] = features[i] + 1.0
        res.append(model.predict(features))
        features[i] -= 1.0
    for i in range(11):
        if res[i]:
            return str(i)
        else:
            return str(random.randint(0, 11)) 

def recv_stat():
    states = [[0 for _ in range(22)]]
    choices = []
    mdl = Model()
    i = 1 
    k = str(sc.recv(1), "utf-8")
    while True:
        print(k)
        cur_choice = int(str(sc.recv(ord(k)), "utf-8"))
        print(cur_choice)
        tmp = 1 if cur_choice > 0 else 0
        choices.append(tmp)
        print("choices " + str(len(choices)))
        #states[i].append(cur_choice)
        
        states.insert(i, [])
        states[i] = states[i - 1].copy()
        print(states)
        print("states " + str(len(states)))
        if cur_choice > 0:
            states[i][cur_choice + 11 - 1] += 1
        elif cur_choice < 0:
            states[i][-1 * cur_choice - 1] += 1
        i += 1
        k = str(sc.recv(1), "utf-8")
        print("ord(k) = " + str(ord(k)))
        if k == "0":
            break
    states.pop(len(states) - 1)
    mdl.fit(states, choices)
    cursor = dbConn.cursor()
    state = ""
    for i in range(22):
        if i == 21:
            state += str(states[len(states) - 1][i])
        else:
	        state += str(states[len(states) - 1][i]) + ";"
    print(state)
    cursor.execute("UPDATE users SET stat=%s WHERE id=%s", (state, str(myid)))
    dbConn.commit()
    cursor.close()

    return mdl, state
    
def get_weights():
    res = ""
    for _ in range(10):
        res += str(random.random()) + ","
    return res

def new_user():
    cursor = dbConn.cursor()
    cursor.execute("SELECT id FROM users")
    
    rows = cursor.fetchall()
    res = str(len(rows) + 1)
    cursor.close()
    cursor = dbConn.cursor()
    cursor.execute("INSERT INTO users(id,stat) VALUES(%s,%s);", (res, ""))
    dbConn.commit()
    cursor.close()
    
    return res


myid = 0
try:
    dbConn = mysql.connector.connect(host=HOST,
                                   database=DATABASE,
                                   user=USER,
                                   password=PASSWORD)
    if dbConn.is_connected():
        print('Connected to MySQL database')
 
except Error as e:
    print(e)

else:
    s = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
    s.bind((ADDRESS, 9999))
    s.listen(10)

    sc, address = s.accept()
    print(address)
    while (True):
        msg = str(sc.recv(1), "utf-8")
        if msg == "0":
            myid = new_user()
            print("id is " + str(myid))
            sc.send(bytes(myid, "utf-8"))
            continue
        elif msg == "1":
            model, state = recv_stat()
            pred = process(state)
            print("pred is " + str(pred))
            sc.send(bytes(pred, "utf-8"))
            break
        elif msg == "2":
            # just finish session
            break
        else:
            print(msg)
            print("Wrong cmd!")
            break

    sc.close()
finally:
    dbConn.close()
