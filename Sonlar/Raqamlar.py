"""
Berilgan son raqamlarini ekranga chiqaring.
Misol uchun, print_digits(154) chaqirilganda, quyidagilar ekranga chiqarishi kerak:
4
5
1
"""

def print_digits(num: int) -> None:
    """
    Kodni bu yerda yozing.
    """
    if num == 0:
        print(0)
        return
    
    while num != 0:
        digit = num % 10
        print(digit)
        num //= 10

print_digits(154)