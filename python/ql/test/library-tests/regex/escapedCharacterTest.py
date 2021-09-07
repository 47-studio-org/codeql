import re

re.compile(r'\b') #$ escapedCharacter=0:2
re.compile(r'''\b''') #$ escapedCharacter=0:2
re.compile(r"\b") #$ escapedCharacter=0:2
re.compile(u"\b") # not escape
re.compile("\b") # not escape
re.compile(r'\\\b') #$ escapedCharacter=0:2 escapedCharacter=2:4
re.compile(r'[\---]') #$ escapedCharacter=1:3
re.compile(r'[--\-]') #$ escapedCharacter=3:5
re.compile(r'[\--\-]') #$ escapedCharacter=1:3 escapedCharacter=4:6
re.compile(r'[0\-9-A-Z]') #$ escapedCharacter=2:4
re.compile(r'[\0-\09]') #$ escapedCharacter=1:3 escapedCharacter=4:7
re.compile(r'[\0123-5]') #$ escapedCharacter=1:5

#ODASA-3985
#Half Surrogate pairs
re.compile(u'[\uD800-\uDBFF][\uDC00-\uDFFF]') # not escapes
#Outside BMP
re.compile(u'[\U00010000-\U0010ffff]') # not escapes

#Misparsed on LGTM
re.compile(r"\[(?P<txt>[^[]*)\]\((?P<uri>[^)]*)") #$ escapedCharacter=0:2 escapedCharacter=16:18 escapedCharacter=18:20
