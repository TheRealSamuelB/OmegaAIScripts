using Enumerator;
namespace DuelBot.Game.AI.Decks
{
    public class PhotonFlashExecutor :  DefaultExecutor
    {
        public static void Init()
        {
            DecksManager.AddDeckType("Photon Flash", DuelRules.SpeedDuel, (ai, duel) => new PhotonFlashExecutor(ai, duel),
                "U2ToZZrGCsPdF5/A8d5P6gwgPPeUCBzvyX3KDMLy8ZOYQNh/YxAYZ3MbgXGh6xkWEHb+aMdix6DMBMIL/L1ZQNjFQJgZhN+rBzIw+2UwgbAc5wrm16U3mUB2AwA="
        }
        public class CardId
        {
            //Monster cards
            
            public const int PhotonDragon = 93717133;
            public const int PhotonLizard = 38973775;
            public const int PhotonCrusher = 1362589;
            public const int PhotonThrasher = 65367484;
            public const int PhotonVanisher = 43147039;
            public const int PhotonPirate   = 36834155;
            public const int PhotonSabreTiger = 80495985;
            public const int PhotonAdvancer = 98881931;
            public const int PhotonChargeman = 2618045;
            
            // Magic & Trap cards Back off Wizards
            
            public const int PhotonBooster = 71233859;
            public const int PhotonLead = 35848254;
            public const int PhotonTrident = 51589188;
            public const int PhotonStreamofDestruction = 72044448;
            public const int MysticalSpaceTyphoon = 5318639;
            
            // Extra Deck
            
            public const int Numbers20 = 47805931;
            public const int StarligePaladynamo = 61344030;
            public const int StarligeLordGalaxion = 40390147
            
        }
        
        
        public PhotonFlashExecutor(GameAI ai, BotDuel duel)
            : base(ai, duel)
            {
                AddExecutor(ExecutorType.Activate, CardId.PhotonVanisher/*,PhotonVanisherEff*/);
                AddExecutor(ExecutorType.spSummon, CardId.StarligeLordGalaxion);
                AddExecutor(ExecutorType.Activate, CardId.StarligeLordGalaxion,StarligeLordGalaxionEff);
                AddExecutor(ExecutorType.Activate, CardId.PhotonLizard,PhotonLizardEff);
                AddExecutor(ExecutorType.spSummon ,CardId.PhotonThrasher,PhotonThrasherSpSummon);
                AddExecutor(ExecutorType.spSummon ,CardId.PhotonVanisher,PhotonVanisherSpSummon);
                AddExecutor(ExecutorType.Summon, CardId.PhotonLizard);
                AddExecutor(ExecutorType.spSummon, CardId.PhotonAdvancer,PhotonAdvancerSpSummon);
                AddExecutor(ExecutorType.Activate, CardId.PhotonLead,LeadEff);
                AddExecutor(ExecutorType.Summon, CardId.PhotonSabreTiger);
                AddExecutor(ExecutorType.Activate, CardId.PhotonSabreTiger/*,PhotonSabreTigerEff*/);
                AddExecutor(ExecutorType.Summon, CardId.PhotonCrusher);
                AddExecutor(ExecutorType.Summon, CardId.PhotonChargeman);
                AddExecutor(ExecutorType.spSummon, CardId.Numbers20);
                AddExecutor(ExecutorType.spSummon ,CardId.StarligePaladynamo);
                AddExecutor(ExecutorType.Activate, CardId.StarligePaladynamo,StarligePaladynamoEff)
                AddExecutor(ExecutorType.Summon, CardId.PhotonAdvancer);
                AddExecutor(ExecutorType.spSummon, CardId.PhotonDragon,);
                AddExecutor(ExecutorType.Summon, CardId.PhotonDragon,);
                AddExecutor(ExecutorType.Activate, CardId.PhotonTrident/*,PhotonTridentEff*/);
                AddExecutor(ExecutorType.Activate, CardId.PhotonBooster,PhotonBoosterEff);
                AddExecutor(ExecutorType.Activate, CardId.PhotonStreamofDestruction,PhotonStreamofDestructionEff);
                AddExecutor(ExecutorType.Activate, CardId.Numbers20);
                AddExecutor(ExecutorType.Activate, CardId.MysticalSpaceTyphoon,DefaultMysticalSpaceTyphoon);
            }
            //default state for 1 per turn effects
        bool usedLizardEff = false;
        bool usedNumbers20Eff = false;
        bool usedGalaxionEff = false;
        
        private bool PhotonThrasherSpSummon ()
        {
            foreach ( ClientCard card in Bot . Hand . GetMonsters ())
            {
                if (!card.Equals(DynamicCard) && card.Level == 4)
                    return true;
            }
            return false;
        }
         
         private bool StarligeLordGalaxionEff ()
         {
             if ( Bot . HasInHand (CardId . PhotonDragon ))
             {
                 return true;
             }
             else
             {
                 //Detach 2 effect what goes here?
                 return false
             }
         }
         
         private bool PhotonVanisherSpSummon ()
         {
             foreach (BotClientCard monster in Bot.GetMonsters())
             {
                 if (monster.Level == 4)
                 {
                     return true;
                 }
                 return false;
             }
             
             private bool LeadEff ()
             {
                 foreach ( ClientCard card in Bot . Hand . GetMonsters ())
                     if ( card.Level == 4)
                     {
                         return true;
                     }
                     return false;
             }
             
             private bool PhotonAdvancerSpSummon ()
             {
                 foreach ( ClientCard card in Bot . Hand . GetMonsters ())
                 {
                     if (!card.Equals(DynamicCard) && card.Level == 4)
                     {
                         return true;
                     }
                     return false;
                 }
                
                private bool PhotonStreamofDestructionEff ()
                 { 
                     BotClientCard target = Util.GetProblematicEnemyCard ():
                     
                     if (!target = null)
                     {
                         AI.SelectCard (target);
                         return true;
                     }
                     return false;
                 }
                 private bool StarligePaladynamoEff ()
                 {
                      BotClientCard target = Util,GetProblematicEnemyMonster ():
                      
                     if (!target = null)
                     {
                         AI.SelectCard (target);
                         return true;
                     }
                     return false;
                 }
                 
                  private bool PhotonLizardEff ()
                
                 if (!Bot . HasInHand (CardId . PhotonAdvancer))
                 {
                     AI.SelectCard(CardId . PhotonAdvancer);
                     return true;
                 }

                 else if (Bot . HasInHand (CardId . PhotonAdvancer))
                 {
                     AI.SelectCard(CardId . PhotonThrasher);
                     return true:
                 }
                  return false
                     
                 
         
                
            