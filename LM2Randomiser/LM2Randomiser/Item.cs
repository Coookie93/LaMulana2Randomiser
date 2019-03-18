﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LM2Randomiser
{
    public class Item
    {
        public string name;
        public ItemID id;
        public bool isRequired;

        public Item(string name, int id, bool isRequired = true)
        {
            this.name = name;
            this.id = (ItemID)id;
            this.isRequired = isRequired;
        }

        public Item(string name, ItemID id, bool isRequired = true)
        {
            this.name = name;
            this.id = id;
            this.isRequired = isRequired;
        }
    }

    public enum ItemID
    {
        Default = -1,
        HandScanner,
        DjedPillar,
        Mjolnir,
        Beherit,
        AncientBattery,
        LampofTime,
        PochetteKey,
        PyramidCrystal,
        CrystalSkull,
        Vessel,
        Pepper,
        EggofCreation,
        GiantsFlute,
        CogofAntiquity,
        MulanaTalisman,
        MobileSuperx3P,
        ShellHorn,
        HolyGrail,
        FairyPass,
        Gloves,
        DinosaurFigure,
        GaleFibula,
        FlameTorc,
        Vajra,
        PowerBand,
        BronzeMirror,
        Perfume,
        IceCloak,
        NemeanFur,
        Gauntlet,
        Anchor,
        FreyasPendant,
        TotemPole,
        GrappleClaw,
        Spaulder,
        Scalesphere,
        Crucifix,
        GaneshaTalisman,
        MaatsFeather,
        Ring,
        Bracelet,
        Feather,
        Scriptures,
        FreysShip,
        Codices,
        SnowShoes,
        Harp,
        BookoftheDead,
        LightScythe,
        DestinyTablet,
        SecretTreasureofLife,
        OriginSigil,
        BirthSigil,
        LifeSigil,
        DeathSigil,
        ClaydollSuit,
        KimonoCowgirl,
        Valkyria,
        LittleDevil,
        EasternEurope,
        Whip,
        ChainWhip,
        FlailWhip,
        Knife,
        Rapier,
        Axe,
        Katana,
        Shuriken,
        RollingShuriken,
        EarthSpear,
        Flare,
        Bomb,
        Chakram,
        Caltrops,
        Pistol,
        Buckler,
        SilverShield,
        AngelShield,
        AnkhJewel,
        Xelputter,
        YagooMapReader,
        YagooMapStreet,
        TextTrax,
        RuinsEncylopedia,
        Mantra,
        Guild,
        Research,
        EngaMusica,
        BeoEglana,
        Alert,
        Snapshot,
        SkullReader,
        RaceScanner,
        DeathVillage,
        RoseandCamelia,
        SpaceCapstarII,
        LonelyHouseMoving,
        MekuriMaster,
        BounceShot,
        MiracleWitch,
        FutureDevelopmentCompany,
        LaMulana,
        LaMulana2,
        SacredOrb0,
        SacredOrb1,
        SacredOrb2,
        SacredOrb3,
        SacredOrb4,
        SacredOrb5,
        SacredOrb6,
        SacredOrb7,
        SacredOrb8,
        SacredOrb9,
        Map1,
        Map2,
        Map3,
        Map4,
        Map5,
        Map6,
        Map7,
        Map8,
        Map9,
        Map10,
        Map11,
        Map12,
        Map13,
        Map14,
        Map15,
        Map16,
        Map17,
        Map18,
        Map19,
        Map20,
        AnkhJewel1,
        AnkhJewel2,
        AnkhJewel3,
        AnkhJewel4,
        AnkhJewel5,
        AnkhJewel6,
        AnkhJewel7,
        AnkhJewel8,
        AnkhJewel9,
        CrystalSkull1,
        CrystalSkull2,
        CrystalSkull3,
        CrystalSkull4,
        CrystalSkull5,
        CrystalSkull6,
        CrystalSkull7,
        CrystalSkull8,
        CrystalSkull9,
        CrystalSkull10,
        CrystalSkull11,
        CrystalSkull12,
        Weights,
        ShurikenAmmo,
        RollingShurikenAmmo,
        EarthSpearAmmo,
        FlareAmmo,
        BombAmmo,
        ChakramAmmo,
        CaltropsAmmo,
        PistolAmmo,
    }
}
