namespace GCPresentation
{
    public static class Program
    {
        private static readonly Dictionary<ActionEnum, Action> _actions = [];

        private static void Main()
        {
            InitializeActions();
            while (true)
            {
                InvokeSelectedAction();
            }
        }

        private static void InvokeSelectedAction()
        {
            int count = 1;
            foreach (var action in _actions)
            {
                Console.WriteLine($"{count}) " + action.Key.ToString());
                count++;
            }
            int selection;
            while (!int.TryParse(Console.ReadLine(), out selection) || selection <= 0 || selection > _actions.Count)
            {
                Console.WriteLine("Selecione um numero correto!");
            }
            _actions[(ActionEnum)selection].Invoke();
        }

        private static void InitializeActions()
        {
            _actions.Add(ActionEnum.MemoryLeak, MemoryLeak.CauseMemoryLeak);
            _actions.Add(ActionEnum.GcCleans, DifferentsGcCleans.GcGensExamples);
        }
    }

    public enum ActionEnum
    {
        None,
        MemoryLeak,
        GcCleans,
    }
}
