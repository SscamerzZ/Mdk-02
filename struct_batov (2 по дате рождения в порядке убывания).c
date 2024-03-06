#include <stdio.h>
#include <string.h>

struct data {
    int god;
    int mes;
    int den;
};

struct student {
    int vozr;
    struct data data_r;
    char fm[100];
    char im[100];
    char ot[100];
};

void swap(struct student *a, struct student *b) {
    struct student t = *a;
    *a = *b;
    *b = t;
}

void sort_birthdate(struct student arr[], int n) {
    for (int i = 0; i < n-1; i++) {
        int imin = i;
        for (int j = i+1; j < n; j++) {
            if (arr[j].data_r.god > arr[imin].data_r.god ||
                (arr[j].data_r.god == arr[imin].data_r.god && arr[j].data_r.mes > arr[imin].data_r.mes) ||
                (arr[j].data_r.god == arr[imin].data_r.god && arr[j].data_r.mes == arr[imin].data_r.mes && arr[j].data_r.den > arr[imin].data_r.den)) {
                imin = j;
            }
        }
        if (imin != i) {
            swap(&arr[i], &arr[imin]);
        }
    }
}

int main() {
    struct student students[3];
    strcpy(students[0].fm, "Батов");
    strcpy(students[0].im, "Дмитрий");
    strcpy(students[0].ot, "Александрович");
    students[0].data_r.god = 2000;
    students[0].data_r.mes = 5;
    students[0].data_r.den = 15;

    strcpy(students[1].fm, "Арутюнян");
    strcpy(students[1].im, "Софья");
    strcpy(students[1].ot, "Кареновна");
    students[1].data_r.god = 2002;
    students[1].data_r.mes = 3;
    students[1].data_r.den = 22;

    strcpy(students[2].fm, "Вагина");
    strcpy(students[2].im, "Полина");
    strcpy(students[2].ot, "Алексеевна");
    students[2].data_r.god = 2001;
    students[2].data_r.mes = 8;
    students[2].data_r.den = 10;

    sort_birthdate(students, 3);
    for (int i = 0; i < 3; i++) {
        printf("%s %s %s %d.%d.%d\n", students[i].fm, students[i].im, students[i].ot, students[i].data_r.den, students[i].data_r.mes, students[i].data_r.god);
    }
    return 0;
}
