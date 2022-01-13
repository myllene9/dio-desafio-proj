import cv2
import numpy as np
from math import sqrt
import time

tempoi = time.time()
img = cv2.imread('testando/quebranovo.png')
cv2.imshow("imagem", img)
print(img.shape)
quebracabeca = cv2.imread("fundo.png")


qtpecas = 20
posicao = []
for m in range(1, qtpecas+1):
    peca = cv2.imread("testando/peca" + str(m) + ".png")
    pontos = []
    for x in range(0, peca.shape[1], 10):
        for y in range(0, peca.shape[0], 10):

            pixel = peca[y][x]
            if pixel[0] < 240 or pixel[1] < 240 or pixel[2] < 240:
                p = (x, y)
                pontos.append(p)

    print(len(pontos))

    #percorrendo a imagem com as informações do contorno
    maxdif = 999999999
    dif = 0
    for i in range(0, img.shape[0] - peca.shape[0]):
        print(i)
        for j in range(0, img.shape[1] - peca.shape[1]):
            dif = float(0)
            for k in range(len(pontos)):
                ponto = pontos[k]
                x = ponto[0]
                y = ponto[1]

                pixel_img = img[y+i][x+j]
                pixel_peca = peca[y][x]

                parter = (float(pixel_img[0])-float(pixel_peca[0]))**2
                parteg = (float(pixel_img[1]) - float(pixel_peca[1])) ** 2
                parteb = (float(pixel_img[2]) - float(pixel_peca[2])) ** 2

                dif = dif + parter + parteg + parteb


            if dif < maxdif:
                maxdif = dif
                pospeca = (i, j)


    posicao.append(pospeca)
    print(pospeca)


    #printando o contorno no lugar da peça no quebra cabeça
    po = posicao[m-1]
    pr = ((po[0]+pospeca[0]+10), (po[1]+pospeca[1]+10))
    quebracabeca[pr[0]:pr[0]+peca.shape[0], pr[1]:pr[1]+peca.shape[1]] = peca
    cv2.imshow("teste1", quebracabeca)
    cv2.waitKey(10)

tempof = time.time()
tempo = tempof - tempoi
print ("posições", posicao)
print ("tempo de execução", tempo)
cv2.waitKey(0)