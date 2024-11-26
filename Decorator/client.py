from concrete_component import ConcreteComponent
from concrete_decorator_a import ConcreteDecoratorA
from concrete_decorator_b import ConcreteDecoratorB

def client_code(component):

    print(f"RESULTADO: {component.operation()}", end="")

if __name__ == "__main__":
    # This way the client code can support both simple components...
    simple = ConcreteComponent()
    print("Cliente: Tengo un componente simple:")
    client_code(simple)
    print("\n")

    # ...as well as decorated ones.
    decorator1 = ConcreteDecoratorA(simple)
    decorator2 = ConcreteDecoratorB(decorator1)
    print("Cliente: Ahora tengo un componente decorado:")
    client_code(decorator2)
