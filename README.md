נושא הפרויקט
מערכת לניהול קורסים ורישומים במרכז הדרכה (Courses & Enrollments Management System).
תיאור הפרויקט
מערכת Back Office פנימית לניהול מוסד לימודי. באמצעות המערכת ניתן לנהל את קטלוג הקורסים המוצעים, לעקוב אחר פרטי הסטודנטים הרשומים, לבצע רישום של סטודנטים לקורסים השונים ולנהל ציונים וסטטוסים.
________________________________________
ישויות
•	סטודנט (Student)
•	קורס (Course)
•	רישום לקורס (Enrollment)
________________________________________
מיפוי Routes לסטודנטים
GET   https://school/students
GET   https://school/students/1
POST   https://school/students
PUT   https://school/students/1
DELETE   https://school/students/1
________________________________________
מיפוי Routes לקורסים
GET   https://school/courses
GET   https://school/courses/1
POST   https://school/courses
PUT   https://school/courses/1
DELETE   https://school/courses/1
________________________________________
מיפוי Routes לרישומים לקורס
GET   https://school/ enrollments
GET   https://school/ enrollments/1
POST   https://school/ enrollments
PUT   https://school/ enrollments/1
DELETE   https://school/ enrollments/1
