#!/usr/bin/env python
# coding: utf-8

# In[ ]:


import sys

class calculator:
    def add(self, x, y):
        return x + y

    def increment(self, x):
        x += 1;
        return x;

#creating object of class
calculatorObj = calculator()
#capturing input from command line and casting to integer
x = sys.argv[1]
y = sys.argv[2]
z = calculatorObj.add(x, y)


import os #THIS
import cv2
text_urdu_list =[]

os.getcwd()
col = "C:\\Users\\humay\\Downloads\\c\\New dataset\\txt\\"
for i, filename in enumerate(os.listdir(col)):
        
        if (i == 77 or i == 78 or i == 79 or i == 80 or i == 81):
              continue
        path_txt = col+str(i)+".txt"
        text_str = open(path_txt, "rb")
        text_string = text_str.read()
        text= text_string.decode("UTF-8")
        text_urdu_list.append(text)
        #print(i)
        
        
from keras.models import load_model
model = load_model("C:\\Users\\humay\\Downloads\\Humayunmodel6.h5")


import cv2
import numpy as np
import matplotlib.pyplot as plt
path = r'D:\img\test.jpg'
img = cv2.imread(path)
img = cv2.cvtColor(img, cv2.COLOR_BGR2RGB)
img = cv2.cvtColor(img, cv2.COLOR_RGB2YUV)
img = cv2.resize(img, (48,48))
img = np.array(img)
img = img/255
img = img.reshape(1,48,48,3)
prediction = model.predict(img)

maxx = max(prediction[0])
listt_x = list(prediction[0])
indexx = listt_x.index(maxx)


x= path.split("/")
x = x[-1]
x=x.split(".")[0]

#img = cv2.imread(path)
#img = cv2.resize(img,(200,200))
#plt.imshow(img)
#print("PREDICTED TEXT :   "+text_urdu_list[indexx])


file_object = open('D:\img\sample.txt', 'w',encoding="utf-8")
# Append 'hello' at the end of file
file_object.write(text_urdu_list[indexx])
# Close the file
file_object.close()


#printing result on console
z=2
print(z)

