#pragma once
#include "Node.h";

class DoublyLinkedList
{
public:
	Node* head;
	int count;

	void Add(int newValue);
	void RemoveFirstValue(int delValue);
	bool IsEmpty();
	DoublyLinkedList();
	~DoublyLinkedList();
	//  Invertir una lista enlazada
	// Funcion que retorne el numero de elementos repetidos.
};

