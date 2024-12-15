using StatePattern.Main;
using StatePattern.StateMachine;

namespace StatePattern.Enemy
{
    public class CloningState<T> : IState where T : EnemyController
    {
        public EnemyController Owner { get; set; }
        private GenericStateMachine<T> stateMachine;

        public CloningState(GenericStateMachine<T> stateMachine) => this.stateMachine = stateMachine;

        public void OnStateEnter()
        {
            // This will create 2 clones on death
            CreateAClone();
            CreateAClone();
        }

        public void Update() { }

        public void OnStateExit() { }

        private void CreateAClone()
        {
            CloneController clonedEnemy = GameService.Instance.EnemyService.CreateEnemy(Owner.Data) as CloneController;
            clonedEnemy.SetCloneCount((Owner as CloneController).CloneCountLeft - 1);
            clonedEnemy.Teleport();
            clonedEnemy.SetDefaultColor(EnemyColorType.Clone);
            clonedEnemy.ChangeColor(EnemyColorType.Clone);
            GameService.Instance.EnemyService.AddEnemy(clonedEnemy);
        }
    }
}