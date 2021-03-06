using Enumerator;
using System.Collections.Generic;
using System.Linq;

{    public class PhantomKnights : DefaultExecutor
     { public static void Init()
   
        DecksManager.AddDeckType("PhantomKnights", DuelRules.MasterDuel, (ai, duel) => new PhantomKnightsExecutor(ai, duel),
                  "s+Gf02rCtK6mmEVfUokVho3NpZhguE3EnfWM7Fpm0xtnwXjxo2RWGNZc38oIwyuePmOCYakr2nC8XvkeAwjf0o1j+HVHhHHZ7C+MkdXJLLtksliOrrzFonxtLhMMx2beg2PXcjfW/Z3XmUC45uNd1k/7WxlhWGbJIZbYEzUsqwQdmR6fL2FadnY3w3TFFFaBk1eYT2tuZ/x+dw8zCC/0mc74Zl09c8x+Q5azDxQZetVnMK99xMUEw/sWVjPA8N/OOawwrDbBiRmGb0/NZoJhUFgBAA==");
     }
public class CardId
private bool wasTornScalesSummonedThisTurn = false;
private bool TornscalesHitGY = false;
private bool RaggedGlovesHitGY = false;
private bool BootsHitGY = false;
private bool AncientCloakHitGY = false;
private List<int> CombosInHand;


{
      //main deck
           //monsters
      public const int DarkMagician = 36996508
      public const int RedEyes = 74677422
      public const int Aleister = 86120751
      public const int Tracker = 30227494
      public const int StainedGreaves = 88544390
      public const int Wheelder = 3233859
      public const int RaggedGloves = 63821877
      public const int AncientCloak = 90432163
      public const int TornScales = 2538345
      public const int Boots = 36426778
      public const int AshBlossom = 14558127
           //spells
      public const int REFusion = 6172122
      public const int FeatherDuster = 18144506
      public const int ROTA = 32807846
      public const int Foolish = 81439173
      public const int TwinTwisters = 43898403
      public const int SuperPoly = 48130397
      public const int PKRankUpMagicForce = 88504133
      public const int MagicalMeltdown = 47679935
      public const int PKRankUpMagicLaunch = 3298689
      public const int Emergency Teleport = 67723438
    //traps
      public const int PKWing = 98431356
      public const int FogBlade = 25542642
      public const int PKsword = 61936647
      public const int SolemnStrike = 40605147
            //Extra Deck Monsters
      public const int Triphy = 79864860
      public const int Dragoon = 37818794
      public const int StarvingVenom = 41209827
      public const int Zeus = 90448279
      public const int ArcRebellion = 64276752
      public const int RaidersKnight = 28781003
      public const int BreakSword =  62709239
      public const int Rusty = 26692769
      public const int Cherubini = 58699500
      public const int Verte = 70369116
      public const int Almiraj = 60303245
      public const int AccessCode = 86066372     
                //side deck
      public const int ArtifactLancea = 34267821
      public const int GateBlocker = 8102334
      public const int IDP = 20899496
      public const int TTT = 25311006
      public const int Nibiru = 27204311
     }
private readonly List<int> Combo_cards = new List<int>()
 {
     CardId.RaggedGloves,
     CardId.Boots,
     CardId.AncientGloves,
     CardId.TornScales,
     CardId.Foolish,
     CardId.StainedGreaves,

 }
private readonly List<int> normal_counter = new List<int>
        {
            53262004, 98338152, 32617464, 45041488,
            61257789, 23440231, 27354732, 12408276, 82419869, 
            49680980, 18621798, 38814750, 17266660, 94689635, 
            74762582, 75286651, 4810828,  44665365, 21123811, 50954680,
            82044279, 82044280, 79606837, 10443957, 1621413,
            90809975, 8165596,  9753964,  53347303, 88307361, 55063751,
            5818294,  2948263,  6150044,  26268488, 51447164, 63941210,
            97268402
        };
private readonly List<int> should_not_negate = new List<int>
        {
            81275020, 28985331
        };

private readonly int[] PK_combo = new[]
        {
            CardId.TornScales,
            CardId.AncientCloak,
            CardId.Boots,
            CardId.RaggedGloves,
            CardId.StainedGreaves,
            CardId.FogBlade,
            CardId.BreakSword,
        };
private readonly int[] = PK_Spell_Trap = new[]
        {
            CardId.FogBlade,
            CardId.PKRankUpMagicForce,
            CardId.PKRankUpMagicLaunch,
            CardId.MagicalMeltdown,

        };
private bool TornScalesUsedThisTurn = false;
private bool wasBootsActivatedThisTurn = false;
private bool wasRaggedGlovesActivatedThisTurn = false;
private bool ScorpioActivatedThisTurn = false;

public PolyKnightsExecutor(GameAI ai, BotDuel duel) : base(ai, duel)
    {
    AddExecutor(ExecutorType.Summon, CardId.Wheelder);
    AddExecutor(ExecutorType.SPSummon, CardId.Wheelder, Wheelder_SPSummon);
    AddExecutor(ExecutorType.SPSummon, CardId.Tracker, Tracker_SPSummon);
    AddExecutor(ExecutorType.Summon, CardId.Tracker);
    AddExecutor(ExecutorType.Summon, CardId.Tornscales);
    AddExecutor(ExecutorType.Activate, CardId.TornScales, TornScales_activate);
    AddExecutor(ExecutorType.Activate, CardId.TornScales, TornScales_GY_act_eff);
    Addexecutor(ExecutorType.SpSummon, CardId.Boots, Boots_SPSummon);
    AddExecutor(ExecutorType.Activate, CardId.Boots, Boots_GY_act_eff);
    AddExecutor(ExecutorType.Summon, CardId.Boots)
    AddExecutor(ExecutorType.Summon, CardId.StainedGreaves);
    AddExecutor(ExecutorType.Activate CardId.StainedGreaves, StainedGreaves_GY_act_eff);
    AddExecutor(ExecutorType.Summon, CardId.AncientCloak);
    AddExecutor(ExecutorType.Activate, CardId.AncientCloak, AncientCloak_GY_act_eff);
    Addexecutor(ExecutorType.Summon, CardId.RaggedGloves);
    AddExecutor(ExecutorType.Activate, CardId.RaggedGloves, RaggedGloves_GY_act_eff);
    AddExecutor(ExecutorType.Summon, CardId.DarkMagician);
    AddExecutor(ExecutorType.Summon, CardId.RedEyes);
    AddExecutor(ExecutorType.Activate, CardId.Ashblossom, Hand_act_eff);
    AddExecutor(ExecutorType.Activate, CardId.REFusion,  REFusion_activate);
    AddExecutor(ExecutorType.Activate, CardId.FeatherDuster, HarpieFeatherDuster);
    AddExecutor(ExecutorType.Activate, CardId.ROTA, ROTA_activate);
    AddExecutor(ExecutorType.Activate, CardId.Foolish, Foolish_activate);
    AddExecutor(ExecutorType.Activate, CardId.TwinTwisters, TwinTwisters_activate);
    AddExecutor(ExecutorType.Activate, CardId.SuperPoly, Superpoly_activate);
    AddExecutor(ExecutorType.Activate, CardId.PKRankUpMagicForce, PKRankUpMagicForce_activate);
    AddExecutor(ExecutorType.Activate, CardId.PKWing, PKWing_Trap_activate, MonsterReborneffect);
    AddExecutor(ExecutorType.Activate, CardId.FogBlade, FogBlade_activate, FogBlade_GY_act_eff);
    AddExecutor(ExecutorType.SPSummon, CardId.Triphy_summon);
    AddExecutor(ExecutorType.SPSummon, CardId.Dragoon, Dragoon_summon);
    AddExecutor(ExecutorType.Activate, CardId.Dragoon, Dragoon_Activate);
    AddExecutor(ExecutorType.SPSummon, CardId StarvingVenom);
    AddExecutor(ExecutorType.Activate, CardId.StarvingVenom, StaringVenom_activate);
    AddExecutor(ExecutorType.SPSummon, CardId.Zeus, Zeus_SPSummon);
    AddExecutor(ExecutorType.Activate, CardId.Zeus, Zeus_activate, Zeus_eff_act);
    AddExecutor(ExecutorType.SPSummon, CardId.RaidersKnight_SPSummon)
    AddExecutor(ExecutorType.Activate, CardId.RaidersKnight, RaidersKnight_activate);
    AddExecutor(ExecutorType.SPSummon, CardId.BreakSword, BreakSword_summon);
    AddExecutor(ExecutorType.Activate, CardId.BreakSword, Breaksword_activate, GY_act_eff);
    AddExecutor(ExecutorType.SPSummon, CardId.Rusty, RustySummon);
    AddExecutor(ExecutorType.Activate, CardId.Rusty, Rusty_activate, Rusty_act_eff);
    AddExecutor(ExecutorType.SPSummon, CardId.Cherubini, CherubiniSummon);
    AddExecutor(ExecutorType.Activate, CardId.Cherubini, Cherubini_activate);
    AddExecutor(ExecutorType.SPSummon, CardId.Verte, Verte_Summon);
    AddExecutor(ExecutorType.Activate, CardId.Verte, Verte_activate);
    AddExecutor(ExecutorType.SPSummon, CardId.Almiraj, Almiraj,summon)
    AddExecutor(ExecutorType.Activate, CardId.Almiraj, Almiraj_activate);
    AddExecutor(ExecutorType.SPSummon, CardId.Megaclops, Megaclops_summon);
    AddExecutor(ExecutorType.Activate, CardId.Megaclops, MegaClops_activate);
    AddExecutor(ExecutorType.SPsummon, CardId.AccessCode, AccessCode_summon);
    AddExecutor(ExecutorTyoe.Activate, CardId.AcessCode, AccessCode_activate);
    AddExecutor(ExecutorType.SPSummon, CardId.Nibiru, Niburu_activate)
    AddExecutor(ExecutorType.Activate, CardId.Lancea, SPSummon);
    AddExecutor(ExecutorType.Activate, CardId.GateBlocker);
    AddExecutor(ExecutorType.Activate, CardId.IDP, IDP-activate);
    AddExecutor(ExecutorType.Activate, CardId.SolemStrike, solemnStrike_activate);

    AddExecutor(ExecutorType.Repos, DefaultMonsterRepos);
    AddExecutor(ExecutorType.SpellSet, SpellSet);
    AddExecutor(ExecutorType.TrapSet, TrapSet);

}
public override bool OnSelectHand()
{
    //dont choose to go first
    return false;

}



public override IList<BotClientCard> OnSelectXyzMaterial(IList<BotClientCard> cards, int min, int max)
{
    IList<BotCLientCard> result = Util.SelectPreferredCards(new[] {
        CardId.Tornscales,
        CardId.RaggedGloves,
        CardId.AncientCloak,
        CardId.StainedGreaves,
        CardId.Ashblossom,
    }, cards, min, max);
    return Util.CheckSelectCount(result, cards, min, max);
};

private bool NormalSummon()
{
    NormalSummoned = true;
    return true;
}

public override CardPosition OnSelectPosition(int cardId, IList<CardPosition> positions)
{
    Card.Card cardData = Card.Manager.GetCard(cardId);
    if (cardData != null)
    {
        if (cardData.Attack <= 1000)
        {
            return CardPosition.FaceUpDefence;
        }
    }
    return 0;
}

private bool TornScales_activate()
{
    if (DynamicCard.Location == CardLocation.MonsterZone)
    {
        wasTornscalesActivatedThisTurn = true;
        break;
    }
    
    else
        if (BotHasInHand.Where(x => PK_combo[]);
    { 
        {
            return true;
        }

         else
        {
            AI.SelectCard(new List<int>()) && AI,SelectNextCard(new List<int>()){
            CardId.RaggedGloves
            CardId.AncientCloak
            CardId.PKWing
            CardId.Boots
            CardId.StainedGreaves
            CardId.FogBlade
            CardId.TornScales

            }
        }
    }
}
private bool TornScales_GY_act_eff()
{
   
}
 {
    { if (DynamicCard.Location == Cardlocation.Graveyard) && if (Bot.HasInGraveyard(new[] {
                CardId.AncientCloak,
                CardId.RaggedGloves,
                CardId.Tornscales,
                CardId.StainedGreaves,
                CardId.Boots,

            }))
        {
            return true;
        }
        
        
       else
        {
            return false;
        }
    }
}

private bool Fogblade_GY_act_eff()
 {
    {
        if (DynamicCard.Location == Cardlocation.Graveyard) && if (Bot.HasInGraveyard(new[] {
                CardId.AncientCloak,
                CardId.RaggedGloves,
                CardId.Tornscales,
                CardId.StainedGreaves,
                CardId.Boots,
                CardId.BreakSword
                CardId.RaidersKnight

            }))
        {
            return true;
        }
        
        else
        {
            return false;
        }
    }
}

private bool PKWing_GY_act_eff()
{
    {
        if (DynamicCard.Location == Cardlocation.Graveyard) && if (Bot.HasInGraveyard(new[] {
                CardId.AncientCloak,
                CardId.RaggedGloves,
                CardId.Tornscales,
                CardId.StainedGreaves,
                CardId.Boots,
                CardId.BreakSword,
                CardId.RaidersKnight,

            }))
        {
            return true;
        }

        else
        {
            return false;
        }
    }
}
private bool ReinforcementofTheArmyEffect()
{
    if (Bot.GetMonsterCount() == 0 && !Bot.HasInHand(CardId.TornScales) 
        {
            AI.SelectCard(new List<int>());
            CardId.Boots
            CardId.AncientCloak
            CardId.RaggedGloves
            CardId.StainedGreaves
         }
        {
            return true;
        }
        {
            else
            {
                AI.SelectCard(PK_Spell_Trap())
            }
        }
}
    if (GoblindberghSummonFirst() && !Bot.HasInHand(CardId.Goblindbergh))
    {
        AI.SelectCard(CardId.Goblindbergh);
        return true;
    }
    AI.SelectCard(new[] {
                CardId.Goblindbergh,
                CardId.RaidenHandofTheLightsworn,
                CardId.PhotonThrasher
            });
    return true;
}

private bool FoolishBurialEffect()
{
    if (!Bot.HasInHandOrInMonstersZoneOrInGraveyard(CardId.TornScales))
    {
        AI.SelectCard(CardId.AncientCloak);
        return true;
    }
    if (L4NonTunerSummonFirst() && Bot.GetRemainingCount(CardId.PerformageTrickClown, 1) > 0)
    {
        AI.SelectCard(CardId.PerformageTrickClown);
        return true;
    }
    AI.SelectCard(new[] {
                CardId.JetSynchron,
                CardId.MechaPhantomBeastOLion,
                CardId.ScrapBeast,
                CardId.PhotonThrasher
            });
    return true;
}