{\rtf1\ansi\ansicpg1252\cocoartf2822
\cocoatextscaling0\cocoaplatform0{\fonttbl\f0\fnil\fcharset0 Monaco;}
{\colortbl;\red255\green255\blue255;\red164\green191\blue255;\red25\green22\blue35;\red255\green255\blue255;
\red252\green115\blue96;\red254\green219\blue112;}
{\*\expandedcolortbl;;\cssrgb\c70196\c80000\c100000;\cssrgb\c12941\c11765\c18431;\cssrgb\c100000\c100000\c100000;
\cssrgb\c100000\c53725\c45098;\cssrgb\c100000\c87843\c51373;}
\paperw11900\paperh16840\margl1440\margr1440\vieww11520\viewh8400\viewkind0
\deftab720
\pard\pardeftab720\partightenfactor0

\f0\fs28 \cf2 \cb3 \expnd0\expndtw0\kerning0
using\cf4  \cf5 System\cf4 ;\cb1 \
\cf2 \cb3 using\cf4  \cf5 System\cf4 .\cf5 Collections\cf4 .\cf5 Generic\cf4 ;\cb1 \
\
\cf2 \cb3 namespace\cf4  \cf2 LibraryManagementSystem\cf4 \cb1 \
\cb3 \{\cb1 \
\cb3   \cf2 class\cf4  \cf2 Library\cf4 \cb1 \
\cb3   \{\cb1 \
\cb3     \cf2 private\cf4  \cf5 List\cf4 <\cf5 Book\cf4 > \cf5 books\cf4  = \cf2 new\cf4  \cf5 List\cf4 <\cf5 Book\cf4 >();\cb1 \
\
\cb3     \cf2 public\cf4  \cf2 void\cf4  \cf5 AddBook\cf4 (\cf5 Book\cf4  \cf5 book\cf4 )\cb1 \
\cb3     \{\cb1 \
\cb3       \cf5 books\cf4 .\cf5 Add\cf4 (\cf5 book\cf4 );\cb1 \
\cb3     \}\cb1 \
\
\cb3     \cf2 public\cf4  \cf5 List\cf4 <\cf5 Book\cf4 > \cf5 SearchBooksByTitle\cf4 (\cf5 string\cf4  \cf5 input\cf4 )\cb1 \
\cb3     \{\cb1 \
\cb3       \cf5 List\cf4 <\cf5 Book\cf4 > \cf5 result\cf4  = \cf2 new\cf4  \cf5 List\cf4 <\cf5 Book\cf4 >();\cb1 \
\
\cb3       \cf2 foreach\cf4 (\cf5 Book\cf4  \cf5 b\cf4  \cf2 in\cf4  \cf5 books\cf4 )\cb1 \
\cb3       \{\cb1 \
\cb3         \cf2 if\cf4 (\cf5 b\cf4 .\cf5 Title\cf4 .\cf5 Contains\cf4 (\cf5 input\cf4 ))\cb1 \
\cb3         \{\cb1 \
\cb3           \cf5 result\cf4 .\cf5 Add\cf4 (\cf5 b\cf4 );\cb1 \
\cb3         \}\cb1 \
\cb3       \}\cb1 \
\
\cb3       \cf2 return\cf4  \cf5 result\cf4 ;\cb1 \
\cb3     \}\cb1 \
\
\cb3     \cf2 public\cf4  \cf2 void\cf4  \cf5 DisplayAllBooks\cf4 ()\cb1 \
\cb3     \{\cb1 \
\cb3       \cf2 foreach\cf4 (\cf5 Book\cf4  \cf5 b\cf4  \cf2 in\cf4  \cf5 books\cf4 )\cb1 \
\cb3       \{\cb1 \
\cb3         \cf5 Console\cf4 .\cf5 WriteLine\cf4 (\cf6 \cb3 $"\{\cf5 \cb3 b\cf4 .\cf5 Title\cf6 \cb3 \} - \{\cf5 \cb3 b\cf4 .\cf5 Author\cf6 \cb3 \}"\cf4 \cb3 );\cb1 \
\cb3       \}\cb1 \
\cb3     \}\cb1 \
\cb3   \}\cb1 \
\cb3 \}\cb1 \
}