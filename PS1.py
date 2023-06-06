#Question 6
def pig():
    word1 = input("Enter your word: ")
    lower_word1 = word1.lower()
    first_letter = lower_word1[0]
    if first_letter in 'aeiou':
        return lower_word1 + "way"
    else:
        return lower_word1[1:] + first_letter + "ay"

print(pig())

#Question 7

def bldcount(bloodfile):
  count_a = 0
  count_b = 0
  count_o = 0
  count_ab = 0
  count_oo = 0
  for bld in bloodfile:
    btypes = bld.strip().split()
    for btype in btypes:
      if btype == 'A':
        count_a += 1
      elif btype == 'B':
        count_b += 1
      elif btype == 'AB':
        count_ab += 1
      elif btype == 'OO':
        count_oo += 1
      elif btype == 'O':
        count_o += 1

  print("There are", count_a, "patients of blood type A")
  print("There are", count_b, "patients of blood type B")
  print("There are", count_ab, "patients of blood type AB")
  print("There are", count_o, "patients of blood type O")
  print("There are", count_oo, "patients of blood type OO")

bfile = open("bloodtype.txt")
bldcount(bfile)
print()
#Question 8

def read_exchange_rates():
    exchange_rates = {
        "AUD": 1.0345157,
        "CHF": 1.0237414,
        "CNY": 0.1550176,
        "DKK": 0.1651442,
        "EUR": 1.2296544,
        "GBP": 1.5550989,
        "HKD": 0.1270207,
        "INR": 0.0177643,
        "JPY": 0.01241401,
        "MXN": 0.0751848,
        "MYR": 0.3145411,
        "NOK": 0.1677063,
        "NZD": 0.8003591,
        "PHP": 0.0233234,
        "SEK": 0.148269,
        "SGD": 0.788871,
        "THB": 0.0313789
    }
    return exchange_rates

def curconv(currency, amount):
    exchange_rates = read_exchange_rates()
    if currency in exchange_rates:
        return amount * exchange_rates[currency]
    else:
        return None

print(curconv('EUR', 100))
print(curconv('JPY', 100))
print()

#Question 9

#Q:Trying to add incompatible variables, as in adding 6 + ‘a’
#A:TypeError will be found.
#Q:Referring to the 12th item of a list that has only 10 items
#A:Index Error will be found.
#Q:Using a value that is out of range for a function’s input, such as calling math.sqrt(-1.0)
#A:Value Error will be found.
#Q:Using an undeclared variable, such as print(x) when x has not been defined
#A:Name Error will be found.
#Q:Trying to open a file that does not exist, such as mistyping the file name or looking in the wrong directory.
#A:FileNotFound Error will be found.

#Question 10
def frequencies():
    text = input("Enter the text to count: ")
    lists = "abcdefghijklmnopqrstuvwxyz"
    voc_list = [0] * 26
    for char in text:
        if char.lower() in lists:
            index = lists.index(char.lower())
            voc_list[index] += 1
    return voc_list

count = frequencies()
print(count)