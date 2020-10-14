Doctor's Office
Our next program is for office administrators to track patients in a doctor's office. Ultimately you will have a doctor's office database with tables for doctor, patient, etc. Build out the following features that let an administrator:

- Doctor  (many to many)
  - name
  - specialty as columns.
- Patient (many to many)
  - Name
  - Birthdate   
DoctorPatient (Join Table)
  - Doc ID
  - Patient ID
SpecialtyDoctor (join Table)
  - Specialty ID
  - Doctor ID
Specialty Group (Many to Many)
  - Specialty 


* Add more than one doctor to a patient.
* many doctors with the same specialty. The doctors have organized themselves into specialty groups. 
* So when a user wants to enter a doctor, they must first select a specialty and then add a doctor from there.
* List all of the doctors in a particular specialty. 
* A doctor can have many specialties. (Hint: change the database from storing specialty as a column to giving it its own table with a relationship to a Doctor object.)
* View a chart of doctors including the number of patients they see. Use the SQL COUNT function; practice your online search skills to figure out how it works. 