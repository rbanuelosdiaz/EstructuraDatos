class Stack:
    def __init__(self):
        self.items = []
    
    def push(self, item):
        self.items.append(item)
    
    def pop(self):
        if not self.is_empty():
            return self.items.pop()
        else:
            return None
    
    def peek(self):
        if not self.is_empty():
            return self.items[-1]  # Retorna el último elemento
        else:
            return None
    
    def is_empty(self):
        return len(self.items) == 0
    
    def print(self):
        if self.is_empty():
            print("La pila está vacía")
        else:
            for item in reversed(self.items):
                print(item)
    
    
# Ejemplo de uso:
pila = Stack()

# Push
pila.push(1)
pila.push(2)
pila.push(3)
pila.push(4)
pila.push(5)

print("Imprimiendo lista original:")
pila.print()

print("------------------------------------")
print("Ejecutando el metodo Pop()")
print("Elemento removido:", pila.pop())
pila.print()

print("------------------------------------")
print("Ejecutando el metodo Push(6)")
pila.push(6)
pila.print()

print("------------------------------------")
print("El tope de la pila es el elemento:", pila.peek())