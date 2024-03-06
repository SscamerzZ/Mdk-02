#define MAXN 100
#include <stdio.h>

void swap(float *, float *);
void selection_sort(float *, int );
void v_print(float *, int);

int main() {
    float v[MAXN];
    int n;
    scanf("%d", &n);
    float x;
    for (n = 0; scanf("%f", &x) == 1; n++) { v[n] = x; }
    /*
    1.2  3.5  5.7  -8.2  2.4  7.0
    */

    selection_sort(v, n);
    v_print(v, n);

    return 0;
}

void swap(float *a, float *b) {
    float t = *a;
    *a = *b;
    *b = t;
}

void selection_sort(float *v, int n) {
    for (int i = 0; i < n-1; i++) {
        int imin = i;
        for (int j=i+1; j < n; j++) {
            if (v[j] < v[imin]) { swap(&v[imin], (v+j)); }
        }
    }
}

void v_print(float *v, int n) {
    printf("[");
    for (int i = 0; i < n; i++) {
        printf("%.2f%s", v[i], (i < n-1 ? ";" : "]\n"));
    }
}
