from decorator import Decorator

class ConcreteDecoratorA(Decorator):

    def operation(self) -> str:

        return f"Decorator - Concreto A({self.component.operation()})"
