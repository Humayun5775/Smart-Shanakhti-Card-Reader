#!/usr/bin/env python
# coding: utf-8

# In[6]:


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


import cv2
import numpy as np

# path
path = r'D:\img\test.jpg'
  
# Using cv2.imread() method
image = cv2.imread(path)


# load the image and display it

# convert the image to grayscale and blur it slightly
gray = cv2.cvtColor(image, cv2.COLOR_BGR2GRAY)
cv2.imwrite("D:\gray.jpg", gray)

blurred = cv2.GaussianBlur(gray, (7, 7), 0)
cv2.imwrite("D:\blurred.jpg", blurred)

# adaptively threshold each neighborhood
thresh = cv2.adaptiveThreshold(blurred, 255,
cv2.ADAPTIVE_THRESH_MEAN_C, cv2.THRESH_BINARY_INV, 21, 22)
cv2.imwrite("D:\savedImage.jpg", thresh)

kernel = np.ones((5,0),np.uint8)
opening = cv2.morphologyEx(thresh, cv2.MORPH_OPEN, kernel)
cv2.imwrite("D:\opening.jpg", opening)


erosion = cv2.erode(opening,kernel,iterations = 1)
cv2.imwrite("D:\eros.jpg", erosion)

img3 = erosion + erosion

cv2.imwrite("D:\adderso.jpg",img3)


ker = np.ones((1,1),np.uint8)
dilation = cv2.dilate(erosion,ker,iterations = 10)
cv2.imwrite("D:\dila.jpg", dilation)



# In[7]:



import requests

url = 'https://app.nanonets.com/api/v2/OCR/Model/8a3ecb9b-3e57-422b-a369-74d8a54b358c/LabelFile/'

data = {'file': open('D:\savedImage.jpg', 'rb')}

response = requests.post(url, auth=requests.auth.HTTPBasicAuth('UIshptsO8Jdce5Mp1RWhiNLOlOeAQaLf', ''), files=data)

#print(response.text)humayun.obaid@ymail.com

index = response.text.find("label")
#print(index)


start = 0
stop = index
# Remove charactes from index 5 to 10
if len(response.text) > stop :
    strObj = response.text[0: start:] + response.text[stop + 8::]
#print(strObj)



index = strObj.find(",")
#print(index)

c = len(strObj)
#print(c)

i = c-index
#print(i)

lab = strObj[:-i-1:]
#print(lab)

a=lab
#////////////////////////////////////////

index = response.text.find("ocr_text")
#print(index)


start = 0
stop = index
# Remove charactes from index 5 to 10
if len(response.text) > stop :
     strObj = response.text[0: start:] + response.text[stop + 11::]
#print(strObj)



index = strObj.find("}")
#print(index)

c = len(strObj)
#print(c)

i = c-index
#print(i)

lab = strObj[:-i-1:]
#print(lab)


#print(strObj)

b=lab

#################################################################################

index = strObj.find("label")
#print(index)


start = 0
stop = index
# Remove charactes from index 5 to 10
if len(strObj) > stop :
    strObj = strObj[0: start:] + strObj[stop + 8::]
#print(strObj)



index = strObj.find(",")
#print(index)

c = len(strObj)
#print(c)

i = c-index
#print(i)

lab = strObj[:-i-1:]
#print(lab)

z=lab
#////////////////////////////////////////

#print (z)
index = strObj.find("ocr_text")
#print(index)


start = 0
stop = index
# Remove charactes from index 5 to 10
if len(strObj) > stop :
     strObj = strObj[0: start:] + strObj[stop + 11::]
#print(strObj)



index = strObj.find("}")
#print(index)

c = len(strObj)
#print(c)

i = c-index
#print(i)

lab = strObj[:-i-1:]
#print(lab)
d=lab

######################################################################################

index = strObj.find("label")
#print(index)


start = 0
stop = index
# Remove charactes from index 5 to 10
if len(strObj) > stop :
    strObj = strObj[0: start:] + strObj[stop + 8::]
#print(strObj)



index = strObj.find(",")
#print(index)

c = len(strObj)
#print(c)

i = c-index
#print(i)

lab = strObj[:-i-1:]
#print(lab)

e=lab
#////////////////////////////////////////

index = strObj.find("ocr_text")
#print(index)


start = 0
stop = index
# Remove charactes from index 5 to 10
if len(strObj) > stop :
     strObj = strObj[0: start:] + strObj[stop + 11::]
#print(strObj)



index = strObj.find("}")
#print(index)

c = len(strObj)
#print(c)

i = c-index
#print(i)

lab = strObj[:-i-1:]
#print(lab)
f=lab

#########################################################################################

index = strObj.find("label")
#print(index)


start = 0
stop = index
# Remove charactes from index 5 to 10
if len(strObj) > stop :
    strObj = strObj[0: start:] + strObj[stop + 8::]
#print(strObj)



index = strObj.find(",")
#print(index)

c = len(strObj)
#print(c)

i = c-index
#print(i)

lab = strObj[:-i-1:]
#print(lab)

g=lab
#////////////////////////////////////////

index = strObj.find("ocr_text")
#print(index)


start = 0
stop = index
# Remove charactes from index 5 to 10
if len(strObj) > stop :
     strObj = strObj[0: start:] + strObj[stop + 11::]
#print(strObj)



index = strObj.find("}")
#print(index)

c = len(strObj)
#print(c)

i = c-index
#print(i)

lab = strObj[:-i-1:]
#print(lab)

h=lab

#######################################################################################

list= str(a)+","+str(b)+","+str(z)+","+str(d)+","+str(e)+","+str(f)+","+str(g)+","+str(h)

#print (list)

file_object = open('D:\img\sampl.txt', 'w',encoding="utf-8")
# Append 'hello' at the end of file
file_object.write(list)
# Close the file
file_object.close()


# In[9]:



#printing result on console
z=2
print(z)


# In[ ]:




