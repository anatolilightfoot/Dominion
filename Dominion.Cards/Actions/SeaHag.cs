﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dominion.Rules;
using Dominion.Rules.Activities;
using Dominion.Rules.CardTypes;
using Dominion.Cards.Curses;

namespace Dominion.Cards.Actions
{
    public class SeaHag : Card, IActionCard, IAttackCard
    {
        public SeaHag() : base(4) { }

        public void Play(TurnContext context)
        {
            context.AddEffect(this, new SeaHagAttack());
        }

        private class SeaHagAttack : AttackEffect
        {
            public override void Attack(Player player, TurnContext context, ICard source)
            {
                if (player.Deck.CardCount + player.Discards.CardCount > 0)
                    player.Deck.MoveTop(1, player.Discards);

                var gainUtil = new GainUtility(context, player);
                gainUtil.Gain<Curse>(c => player.Deck.MoveToTop(c));
            }
        }
    }
}
