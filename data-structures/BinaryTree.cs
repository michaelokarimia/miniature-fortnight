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

            public BinaryTree AddLeft(int value)
            {
                var newTree = new BinaryTree(value);
                LeftTree = newTree;
                return newTree;
                
            }

            public BinaryTree AddRight(int value)
            {
                var newTree = new BinaryTree(value);
                RightTree = newTree;
                return newTree;
            }
        }
    }