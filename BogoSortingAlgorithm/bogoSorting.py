## BOGO Sorting Algorithm

import random

def bogo(inputs, output):
	inputArray = []
	count= 0
	for i in inputs:
		inputArray.append(i)
	newWord = inputs
	while newWord != output:
		print newWord
		newWord = ""
		random.shuffle(inputArray)
		count+=1
		for i in inputArray:
			newWord = newWord + i
	print count
