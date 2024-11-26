from decorator import Decorator

class ConcreteDecoratorB(Decorator):

    def operation(self) -> str:

        return f"Decorator - Concreto B({self.component.operation()})"
