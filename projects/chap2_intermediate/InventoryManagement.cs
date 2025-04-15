{\rtf1\ansi\ansicpg1252\cocoartf2822
\cocoatextscaling0\cocoaplatform0{\fonttbl\f0\fnil\fcharset0 Monaco;}
{\colortbl;\red255\green255\blue255;\red164\green191\blue255;\red25\green22\blue35;\red255\green255\blue255;
\red252\green115\blue96;\red129\green131\blue134;\red254\green219\blue112;}
{\*\expandedcolortbl;;\cssrgb\c70196\c80000\c100000;\cssrgb\c12941\c11765\c18431;\cssrgb\c100000\c100000\c100000;
\cssrgb\c100000\c53725\c45098;\cssrgb\c57647\c58431\c59608;\cssrgb\c100000\c87843\c51373;}
\paperw11900\paperh16840\margl1440\margr1440\vieww11520\viewh8400\viewkind0
\deftab720
\pard\pardeftab720\partightenfactor0

\f0\fs28 \cf2 \cb3 \expnd0\expndtw0\kerning0
\outl0\strokewidth0 \strokec2 using\cf4 \strokec4  \cf5 \strokec5 System\cf4 \strokec4 ;\cb1 \
\cf2 \cb3 \strokec2 using\cf4 \strokec4  \cf5 \strokec5 System\cf4 \strokec4 .\cf5 \strokec5 Collections\cf4 \strokec4 .\cf5 \strokec5 Generic\cf4 \strokec4 ;\cb1 \
\
\cf2 \cb3 \strokec2 public\cf4 \strokec4  \cf2 \strokec2 class\cf4 \strokec4  \cf2 \strokec2 InventoryManagement\cf4 \cb1 \strokec4 \
\pard\pardeftab720\partightenfactor0
\cf4 \cb3 \{\cb1 \
\cb3   \cf2 \strokec2 public\cf4 \strokec4  \cf2 \strokec2 static\cf4 \strokec4  \cf2 \strokec2 void\cf4 \strokec4  \cf5 \strokec5 Main\cf4 \strokec4 (\cf5 \strokec5 string\cf4 \strokec4 [] \cf5 \strokec5 args\cf4 \strokec4 )\{\cb1 \
\cb3     \cf6 \strokec6 // Your code goes here\cf4 \cb1 \strokec4 \
\cb3     \cf5 \strokec5 List\cf4 \strokec4 <\cf5 \strokec5 string\cf4 \strokec4 > \cf5 \strokec5 inventoryList\cf4 \strokec4  = \cf2 \strokec2 new\cf4 \strokec4  \cf5 \strokec5 List\cf4 \strokec4 <\cf5 \strokec5 string\cf4 \strokec4 >();\cb1 \
\
\cb3     \cf5 \strokec5 inventoryList\cf4 \strokec4 .\cf5 \strokec5 Add\cf4 \strokec4 (\cf7 \strokec7 "Printer"\cf4 \strokec4 );\cb1 \
\cb3     \cf5 \strokec5 inventoryList\cf4 \strokec4 .\cf5 \strokec5 Add\cf4 \strokec4 (\cf7 \strokec7 "Laptop"\cf4 \strokec4 );\cb1 \
\cb3     \cf5 \strokec5 inventoryList\cf4 \strokec4 .\cf5 \strokec5 Add\cf4 \strokec4 (\cf7 \strokec7 "Desk Chair"\cf4 \strokec4 );\cb1 \
\cb3     \cf5 \strokec5 inventoryList\cf4 \strokec4 .\cf5 \strokec5 Add\cf4 \strokec4 (\cf7 \strokec7 "Monitor"\cf4 \strokec4 );\cb1 \
\cb3     \cf5 \strokec5 inventoryList\cf4 \strokec4 .\cf5 \strokec5 Add\cf4 \strokec4 (\cf7 \strokec7 "Keyboard"\cf4 \strokec4 );\cb1 \
\
\cb3     \cf5 \strokec5 Console\cf4 \strokec4 .\cf5 \strokec5 WriteLine\cf4 \strokec4 (\cf5 \strokec5 inventoryList\cf4 \strokec4 .\cf5 \strokec5 Count\cf4 \strokec4 );\cb1 \
\
\cb3     \cf5 \strokec5 bool\cf4 \strokec4  \cf5 \strokec5 hasDeskChair\cf4 \strokec4  = \cf5 \strokec5 inventoryList\cf4 \strokec4 .\cf5 \strokec5 Contains\cf4 \strokec4 (\cf7 \strokec7 "Desk Chair"\cf4 \strokec4 );\cb1 \
\cb3     \cf5 \strokec5 Console\cf4 \strokec4 .\cf5 \strokec5 WriteLine\cf4 \strokec4 (\cf5 \strokec5 hasDeskChair\cf4 \strokec4 );\cb1 \
\
\cb3     \cf5 \strokec5 bool\cf4 \strokec4  \cf5 \strokec5 removed\cf4 \strokec4  = \cf5 \strokec5 inventoryList\cf4 \strokec4 .\cf5 \strokec5 Remove\cf4 \strokec4 (\cf7 \strokec7 "Printer"\cf4 \strokec4 );\cb1 \
\cb3     \cf5 \strokec5 Console\cf4 \strokec4 .\cf5 \strokec5 WriteLine\cf4 \strokec4 (\cf5 \strokec5 removed\cf4 \strokec4 );\cb1 \
\
\cb3     \cf2 \strokec2 foreach\cf4 \strokec4 (\cf5 \strokec5 string\cf4 \strokec4  \cf5 \strokec5 item\cf4 \strokec4  \cf2 \strokec2 in\cf4 \strokec4  \cf5 \strokec5 inventoryList\cf4 \strokec4 )\cb1 \
\cb3     \{\cb1 \
\cb3       \cf5 \strokec5 Console\cf4 \strokec4 .\cf5 \strokec5 WriteLine\cf4 \strokec4 (\cf5 \strokec5 item\cf4 \strokec4 );\cb1 \
\cb3     \}\cb1 \
\
\cb3     \cf5 \strokec5 List\cf4 \strokec4 <\cf5 \strokec5 string\cf4 \strokec4 > \cf5 \strokec5 newItems\cf4 \strokec4  = \cf2 \strokec2 new\cf4 \strokec4  \cf5 \strokec5 List\cf4 \strokec4 <\cf5 \strokec5 string\cf4 \strokec4 >() \{\cf7 \strokec7 "Mouse"\cf4 \strokec4 , \cf7 \strokec7 "Desk Lamp"\cf4 \strokec4 \};\cb1 \
\
\cb3     \cf5 \strokec5 inventoryList\cf4 \strokec4 .\cf5 \strokec5 AddRange\cf4 \strokec4 (\cf5 \strokec5 newItems\cf4 \strokec4 );\cb1 \
\
\cb3     \cf5 \strokec5 int\cf4 \strokec4  \cf5 \strokec5 startIndex\cf4 \strokec4  = \cf5 \strokec5 inventoryList\cf4 \strokec4 .\cf5 \strokec5 Count\cf4 \strokec4  - \cf5 \strokec5 2\cf4 \strokec4 ;\cb1 \
\cb3     \cf5 \strokec5 inventoryList\cf4 \strokec4 .\cf5 \strokec5 RemoveRange\cf4 \strokec4 (\cf5 \strokec5 startIndex\cf4 \strokec4 , \cf5 \strokec5 2\cf4 \strokec4 );\cb1 \
\
\cb3     \cf5 \strokec5 List\cf4 \strokec4 <\cf5 \strokec5 string\cf4 \strokec4 > \cf5 \strokec5 topInventory\cf4 \strokec4  = \cf5 \strokec5 inventoryList\cf4 \strokec4 .\cf5 \strokec5 GetRange\cf4 \strokec4 (\cf5 \strokec5 0\cf4 \strokec4 , \cf5 \strokec5 3\cf4 \strokec4 );\cb1 \
\
\cb3     \cf2 \strokec2 foreach\cf4 \strokec4  (\cf5 \strokec5 string\cf4 \strokec4  \cf5 \strokec5 item\cf4 \strokec4  \cf2 \strokec2 in\cf4 \strokec4  \cf5 \strokec5 topInventory\cf4 \strokec4 )\cb1 \
\cb3     \{\cb1 \
\cb3       \cf5 \strokec5 Console\cf4 \strokec4 .\cf5 \strokec5 WriteLine\cf4 \strokec4 (\cf5 \strokec5 item\cf4 \strokec4 );\cb1 \
\cb3     \}\cb1 \
\cb3   \}\cb1 \
\cb3 \}\cb1 \
}