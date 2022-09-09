"""
Berilgan so'z palindrom ekanligiga tekshiring.
Misol uchun:
  is_palindrome("kiyik") = True
  is_palindrome("aziza") = True
  is_palindrome("anora") = False
"""

def is_palindrome(word: str) -> bool:
    """
    Kodni bu yerda yozing.
    """
    # O(n) xotira, O(2n) = O(n)
    # return word = word[::-1]
    
    low, high = 0, len(word) -1
    
    while low < high:
        if word[low] != word[high]:
            return False
        low += 1
        high -= 1
    # O(n/2) - vaqt, O(1) - xotira
    return True