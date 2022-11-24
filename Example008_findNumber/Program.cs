int Maximum (int arg1, int arg2, int arg3 ){
int result = arg1;
if ( arg2 > result){
    result = arg2;
    if ( arg3 > result){
    result = arg3;
    }
}
 return result;
}
int a1 = 22;
int b1 = 32;
int c1 = 42;
int d1 = 52;
int e1 = 62;
int f1 = 72;
int g1 = 82;
int h1 = 492;
int k1 = 122;

// int max1 = Maximum(a1,b1,c1);
// int max2 = Maximum(d1,e1,f1);
// int max3 = Maximum(g1,h1,k1);

int maxumus = Maximum ( Maximum(a1,b1,c1), Maximum(d1,e1,f1),  Maximum(g1,h1,k1));// более короткий вариант;

Console.WriteLine(maxumus);