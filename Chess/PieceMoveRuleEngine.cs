using Chess.Core.Models;
using Chess.Core.Rules;
namespace Chess.App
{
    public class PieceMoveRuleEngine
    {
        private readonly IEnumerable<BaseRule> _rules = new List<BaseRule>();
        private PieceMoveRuleEngine(IEnumerable<BaseRule> rules)
        {
            _rules = rules;
        }

        public void ApplyRules(Board_PieceProxy _boardpiece, PieceProxy _move)
        {
            //Se hace un foreach que recorre las reglas
            foreach (var rule in _rules)
            {
                //Luego de hacer match, se aplica la regla encontrada
                if (rule.IsMatch(_boardpiece, _move))
                {
                    rule.Apply(_boardpiece, _move);
                    break;
                }
            }
        }

        //Se crea la clase builder para añadir reglas
        public class Builder
        {
            private readonly List<BaseRule> _rules = new List<BaseRule>();

            public Builder WithBlackPawn()
            {
                _rules.Add(new BlackPawnRule());
                return this;
            }

            public Builder WithWhitePawn()
            {
                _rules.Add(new WhitePawnRule());
                return this;
            }

            public Builder WithTower()
            {
                _rules.Add(new TowerRule());
                return this;
            }

            public Builder WithHorse()
            {
                _rules.Add(new HorseRule());
                return this;
            }

            public PieceMoveRuleEngine Build()
            {
                _rules.Add(new NormalPieceRule());
                return new PieceMoveRuleEngine(_rules);
            }
        }
    }
}
