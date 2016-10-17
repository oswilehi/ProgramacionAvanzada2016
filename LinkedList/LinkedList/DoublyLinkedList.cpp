#include "stdafx.h"
#include "DoublyLinkedList.h"


void DoublyLinkedList::Add(int newVal)
{
	if (head ==  NULL)
	{
		head = new Node(); // Crea una instancia y hace que la variable apunte a esa instancia
		head->value = newVal;
		head->previous = NULL;
		head->next = NULL;
	}
	else
	{
		Node* temporal = head;
		while (temporal->next != NULL)
		{
			temporal = temporal->next;
		}
		Node* newElement = new Node(); 
		newElement->value = newVal;
		newElement->next = NULL;
		newElement->previous = temporal;
		temporal->next = newElement;
	}
	count++;
}

void DoublyLinkedList::RemoveFirstValue(int delValue)
{
	Node* current = head->next;
	if (head->next == NULL && head->value == delValue)
	{
		head = NULL;
		return;
	}
	while (current != NULL)
	{
		if (current->value == delValue)
		{
			current->previous->next = current->next;
			current->next->previous = current->previous;
			delete(current); // Se elimina el nodo en que estamos para que el sistema pueda usar esta memoria.
			count--;
			return;
		}
		else
		{
			current = current->next; //Como es un ciclo si no encuentra un valor en el if, necesita irse al siguiente valor o nodo.
		}
	}
	
}

DoublyLinkedList::DoublyLinkedList()
{
}


DoublyLinkedList::~DoublyLinkedList()
{
}
