
class estudiante:

    # Constructor
    def __init__(self, nombre, carrera, cantidad_calificaciones):
        self.nombre = nombre
        self.carrera = carrera

        # Arreglo de calificaciones
        self.calificaciones = [0] * cantidad_calificaciones

    # Método para capturar las calificaciones
    def capturar_calificaciones(self):
        for i in range(len(self.calificaciones)):
            print("Ingresa la calificación", i + 1, ": ", end="")
            self.calificaciones[i] = float(input())

    # Método para obtener el promedio
    def obtener_promedio(self):
        suma = 0

        for i in range(len(self.calificaciones)):
            suma += self.calificaciones[i]

        return suma / len(self.calificaciones)

    # Método para decir si el estudiante es regular
    def es_regular(self):
        promedio = self.obtener_promedio()

        if promedio >= 70:
            return "El estudiante es regular."
        else:
            return "El estudiante no es regular."
