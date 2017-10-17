namespace data_structures
{
    public class BinaryTree
    {
        private int _value;
        
        public BinaryTree(int val)
            {
                Value = val;
            }

            public BinaryTree LeftTree { get; private set; }
            public BinaryTree RightTree { get; private set; }
            public int Value { get => _value; private set => _value = value; }

            public void AddLeft(int value)
            {
                LeftTree = new BinaryTree(value);
            }

            public void AddRight(int value)
            {
                RightTree = new BinaryTree(value);
            }
        }
    }