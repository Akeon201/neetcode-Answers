class Solution:
    def isAnagram(self, s: str, t: str) -> bool:
        max_len = max(len(s), len(t))
        s = sorted(s)
        t = sorted(t)

        for i in range(max_len):
            try:
                if s[i] != t[i]:
                    return False
            except:
                return False

        return True