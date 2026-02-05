#include <iostream>

class FracNum
{
    private:
        int first;
        unsigned int second;
    public:
        FracNum(): first(0), second(1) {}
        FracNum(int first, unsigned int second): first(first), second(second) {}
        void Read(int value1, unsigned int value2)
        {
            first = value1;
            second = value2;
        }
        void Display()
        {
            std::cout << "The number: " << first << "/" << second << std::endl;
        }
        void Multiply(int value)
        {
            first *= value;
        }
};

int main()
{
    FracNum frac;
    frac.Read(15, 30);
    frac.Display();
    frac.Multiply(5);
    frac.Display();
    return 0;
}