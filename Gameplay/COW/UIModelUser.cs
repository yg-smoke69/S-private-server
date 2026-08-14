using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;
using tcp;

namespace COW;

[Token(Token = "0x20032A8")]
internal class UIModelUser : UIBaseModel
{
	[Token(Token = "0x20032A9")]
	public enum RegisterFlowBit
	{
		[Token(Token = "0x40134A4")]
		RegisterComplete,
		[Token(Token = "0x40134A5")]
		IsClassicBROpen,
		[Token(Token = "0x40134A6")]
		IsTutorialBROpen,
		[Token(Token = "0x40134A7")]
		IsTutorialCSOpen,
		[Token(Token = "0x40134A8")]
		BRClassicFinish,
		[Token(Token = "0x40134A9")]
		BRTutorialFinish,
		[Token(Token = "0x40134AA")]
		EnteredCSTutorialMode,
		[Token(Token = "0x40134AB")]
		EnteredCSMode,
		[Token(Token = "0x40134AC")]
		CSPopUpFinishedByAfterBR,
		[Token(Token = "0x40134AD")]
		CSPopUpFinishedByModelChoice,
		[Token(Token = "0x40134AE")]
		IsSinglePlayerForceTutorialOpen,
		[Token(Token = "0x40134AF")]
		SinglePlayerForceTutorialFinish,
		[Token(Token = "0x40134B0")]
		CSTutorialABTest
	}

	[Token(Token = "0x4013481")]
	[FieldOffset(Offset = "0xC")]
	private LoginRes _003CUserLoginData_003Ek__BackingField;

	[Token(Token = "0x4013482")]
	[FieldOffset(Offset = "0x10")]
	private ulong _003CAccountID_003Ek__BackingField;

	[Token(Token = "0x4013483")]
	[FieldOffset(Offset = "0x18")]
	private ulong _003CRegisterTime_003Ek__BackingField;

	[Token(Token = "0x4013484")]
	[FieldOffset(Offset = "0x20")]
	private string _003CNickname_003Ek__BackingField;

	[Token(Token = "0x4013485")]
	[FieldOffset(Offset = "0x24")]
	private uint _003CRole_003Ek__BackingField;

	[Token(Token = "0x4013486")]
	[FieldOffset(Offset = "0x28")]
	private ulong _003CClanID_003Ek__BackingField;

	[Token(Token = "0x4013487")]
	[FieldOffset(Offset = "0x30")]
	private string _003CClanName_003Ek__BackingField;

	[Token(Token = "0x4013488")]
	[FieldOffset(Offset = "0x34")]
	private uint _003CUserCoins_003Ek__BackingField;

	[Token(Token = "0x4013489")]
	[FieldOffset(Offset = "0x38")]
	private int m_UserGems;

	[Token(Token = "0x401348A")]
	[FieldOffset(Offset = "0x3C")]
	private proto.EAntiAddiction.AgeState m_AgeState;

	[Token(Token = "0x401348B")]
	[FieldOffset(Offset = "0x40")]
	private proto.EAntiAddiction.AgeState m_PreviousAgeState;

	[Token(Token = "0x401348C")]
	[FieldOffset(Offset = "0x44")]
	private proto.EAccount.NewbieChoice m_NewbieChoice;

	[Token(Token = "0x401348D")]
	private const string KeyDoneSinglePlayerForceTutorialGame = "DoneSinglePlayerForceTutorialGame";

	[Token(Token = "0x401348E")]
	[FieldOffset(Offset = "0x48")]
	public bool DoneSinglePlayerForceTutorialGameDuringStartup;

	[Token(Token = "0x401348F")]
	[FieldOffset(Offset = "0x49")]
	private bool m_NeedShowLevelUpWindow;

	[Token(Token = "0x4013490")]
	[FieldOffset(Offset = "0x4C")]
	private List<RegionIDMapping> m_RegionList;

	[Token(Token = "0x4013491")]
	[FieldOffset(Offset = "0x50")]
	private bool _003CHasElitePass_003Ek__BackingField;

	[Token(Token = "0x4013492")]
	[FieldOffset(Offset = "0x54")]
	private uint _003CBadgeItemId_003Ek__BackingField;

	[Token(Token = "0x4013493")]
	[FieldOffset(Offset = "0x58")]
	private uint _003CBadgeItemCount_003Ek__BackingField;

	[Token(Token = "0x4013494")]
	[FieldOffset(Offset = "0x5C")]
	private uint _003CEmulatorScore_003Ek__BackingField;

	[Token(Token = "0x4013495")]
	public const uint PropID_ResourceUpdate = 2u;

	[Token(Token = "0x4013496")]
	public const uint PropID_UserProfileUpdate = 4u;

	[Token(Token = "0x4013497")]
	public const uint PropID_UserRenameError = 8u;

	[Token(Token = "0x4013498")]
	public const uint PropID_UserRenameSuccess = 16u;

	[Token(Token = "0x4013499")]
	public const uint PropID_UserLevelUp = 32u;

	[Token(Token = "0x401349A")]
	public const uint PropID_CheckCdKeyError = 64u;

	[Token(Token = "0x401349B")]
	public const uint PropID_CheckEmailError = 128u;

	[Token(Token = "0x401349C")]
	public const uint PropID_CheckCdKeySuccess = 256u;

	[Token(Token = "0x401349D")]
	private const string CharacterSet = "a0bcdefg1hjkm2npqrs3tuv456789wxy";

	[Token(Token = "0x401349E")]
	private const string EncKey = "QDENCRYPTKEY";

	[Token(Token = "0x401349F")]
	[FieldOffset(Offset = "0x0")]
	private static string RegisterPlayerPrefKey;

	[Token(Token = "0x40134A0")]
	[FieldOffset(Offset = "0x4")]
	private static Converter<string, int> _003C_003Ef__mg_0024cache0;

	[Token(Token = "0x40134A1")]
	[FieldOffset(Offset = "0x8")]
	private static TCPParameters.KickByServerMsgDeserializer _003C_003Ef__am_0024cache0;

	[Token(Token = "0x40134A2")]
	[FieldOffset(Offset = "0xC")]
	private static Action<HttpErrorCode, object> _003C_003Ef__am_0024cache1;

	[Token(Token = "0x17001682")]
	public LoginRes UserLoginData
	{
		[Token(Token = "0x6015586")]
		[Address(RVA = "0x168C2E8", Offset = "0x168C2E8", VA = "0x168C2E8")]
		get
		{
			return null;
		}
		[Token(Token = "0x6015587")]
		[Address(RVA = "0x16A3A0C", Offset = "0x16A3A0C", VA = "0x16A3A0C")]
		private set
		{
		}
	}

	[Token(Token = "0x17001683")]
	public ulong AccountID
	{
		[Token(Token = "0x6015588")]
		[Address(RVA = "0x1691228", Offset = "0x1691228", VA = "0x1691228")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6015589")]
		[Address(RVA = "0x16A3A14", Offset = "0x16A3A14", VA = "0x16A3A14")]
		private set
		{
		}
	}

	[Token(Token = "0x17001684")]
	public ulong RegisterTime
	{
		[Token(Token = "0x601558A")]
		[Address(RVA = "0x16A3A24", Offset = "0x16A3A24", VA = "0x16A3A24")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x601558B")]
		[Address(RVA = "0x16A3A2C", Offset = "0x16A3A2C", VA = "0x16A3A2C")]
		private set
		{
		}
	}

	[Token(Token = "0x17001685")]
	public string Nickname
	{
		[Token(Token = "0x601558C")]
		[Address(RVA = "0x16992B8", Offset = "0x16992B8", VA = "0x16992B8")]
		get
		{
			return null;
		}
		[Token(Token = "0x601558D")]
		[Address(RVA = "0x16A3A3C", Offset = "0x16A3A3C", VA = "0x16A3A3C")]
		private set
		{
		}
	}

	[Token(Token = "0x17001686")]
	public uint Role
	{
		[Token(Token = "0x601558E")]
		[Address(RVA = "0x16A3A44", Offset = "0x16A3A44", VA = "0x16A3A44")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x601558F")]
		[Address(RVA = "0x16A3A4C", Offset = "0x16A3A4C", VA = "0x16A3A4C")]
		private set
		{
		}
	}

	[Token(Token = "0x17001687")]
	public ulong ClanID
	{
		[Token(Token = "0x6015590")]
		[Address(RVA = "0x16A3A54", Offset = "0x16A3A54", VA = "0x16A3A54")]
		get
		{
			return default(ulong);
		}
		[Token(Token = "0x6015591")]
		[Address(RVA = "0x16A3A5C", Offset = "0x16A3A5C", VA = "0x16A3A5C")]
		private set
		{
		}
	}

	[Token(Token = "0x17001688")]
	public string ClanName
	{
		[Token(Token = "0x6015592")]
		[Address(RVA = "0x16A3A6C", Offset = "0x16A3A6C", VA = "0x16A3A6C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6015593")]
		[Address(RVA = "0x16A3A74", Offset = "0x16A3A74", VA = "0x16A3A74")]
		private set
		{
		}
	}

	[Token(Token = "0x17001689")]
	public uint UserCoins
	{
		[Token(Token = "0x6015594")]
		[Address(RVA = "0x16A3A7C", Offset = "0x16A3A7C", VA = "0x16A3A7C")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6015595")]
		[Address(RVA = "0x16A3A84", Offset = "0x16A3A84", VA = "0x16A3A84")]
		private set
		{
		}
	}

	[Token(Token = "0x1700168A")]
	public int UserGems
	{
		[Token(Token = "0x6015596")]
		[Address(RVA = "0x16A3A8C", Offset = "0x16A3A8C", VA = "0x16A3A8C")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6015597")]
		[Address(RVA = "0x16A3AE4", Offset = "0x16A3AE4", VA = "0x16A3AE4")]
		private set
		{
		}
	}

	[Token(Token = "0x1700168B")]
	public uint UserLevel
	{
		[Token(Token = "0x6015598")]
		[Address(RVA = "0x16A3B44", Offset = "0x16A3B44", VA = "0x16A3B44")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6015599")]
		[Address(RVA = "0x16A3BB0", Offset = "0x16A3BB0", VA = "0x16A3BB0")]
		private set
		{
		}
	}

	[Token(Token = "0x1700168C")]
	public proto.EAntiAddiction.AgeState AgeState
	{
		[Token(Token = "0x601559A")]
		[Address(RVA = "0x16A3CB8", Offset = "0x16A3CB8", VA = "0x16A3CB8")]
		get
		{
			return default(proto.EAntiAddiction.AgeState);
		}
		[Token(Token = "0x601559B")]
		[Address(RVA = "0x16A3D10", Offset = "0x16A3D10", VA = "0x16A3D10")]
		set
		{
		}
	}

	[Token(Token = "0x1700168D")]
	public proto.EAntiAddiction.AgeState PreviousAgeState
	{
		[Token(Token = "0x601559C")]
		[Address(RVA = "0x16A3D70", Offset = "0x16A3D70", VA = "0x16A3D70")]
		get
		{
			return default(proto.EAntiAddiction.AgeState);
		}
		[Token(Token = "0x601559D")]
		[Address(RVA = "0x16A3DC8", Offset = "0x16A3DC8", VA = "0x16A3DC8")]
		set
		{
		}
	}

	[Token(Token = "0x1700168E")]
	public uint UserExp
	{
		[Token(Token = "0x601559E")]
		[Address(RVA = "0x16A3E28", Offset = "0x16A3E28", VA = "0x16A3E28")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x601559F")]
		[Address(RVA = "0x16A3E98", Offset = "0x16A3E98", VA = "0x16A3E98")]
		set
		{
		}
	}

	[Token(Token = "0x1700168F")]
	public proto.EAccount.NewbieChoice NewbieChoice
	{
		[Token(Token = "0x60155A0")]
		[Address(RVA = "0x16A3F10", Offset = "0x16A3F10", VA = "0x16A3F10")]
		get
		{
			return default(proto.EAccount.NewbieChoice);
		}
	}

	[Token(Token = "0x17001690")]
	public bool NeedShowLevelUpWindow
	{
		[Token(Token = "0x60155A6")]
		[Address(RVA = "0x16A4948", Offset = "0x16A4948", VA = "0x16A4948")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60155A7")]
		[Address(RVA = "0x16A49A0", Offset = "0x16A49A0", VA = "0x16A49A0")]
		set
		{
		}
	}

	[Token(Token = "0x17001691")]
	public List<RegionIDMapping> RegionList
	{
		[Token(Token = "0x60155A8")]
		[Address(RVA = "0x16A4A00", Offset = "0x16A4A00", VA = "0x16A4A00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001692")]
	public bool HasElitePass
	{
		[Token(Token = "0x60155A9")]
		[Address(RVA = "0x16A4A58", Offset = "0x16A4A58", VA = "0x16A4A58")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60155AA")]
		[Address(RVA = "0x16A4A60", Offset = "0x16A4A60", VA = "0x16A4A60")]
		private set
		{
		}
	}

	[Token(Token = "0x17001693")]
	public uint BadgeItemId
	{
		[Token(Token = "0x60155AB")]
		[Address(RVA = "0x16A4A68", Offset = "0x16A4A68", VA = "0x16A4A68")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60155AC")]
		[Address(RVA = "0x16A4A70", Offset = "0x16A4A70", VA = "0x16A4A70")]
		private set
		{
		}
	}

	[Token(Token = "0x17001694")]
	public uint BadgeItemCount
	{
		[Token(Token = "0x60155AD")]
		[Address(RVA = "0x16A4A78", Offset = "0x16A4A78", VA = "0x16A4A78")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60155AE")]
		[Address(RVA = "0x16A4A80", Offset = "0x16A4A80", VA = "0x16A4A80")]
		private set
		{
		}
	}

	[Token(Token = "0x17001695")]
	public uint EmulatorScore
	{
		[Token(Token = "0x60155AF")]
		[Address(RVA = "0x16A4A88", Offset = "0x16A4A88", VA = "0x16A4A88")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x60155B0")]
		[Address(RVA = "0x16A4A90", Offset = "0x16A4A90", VA = "0x16A4A90")]
		set
		{
		}
	}

	[Token(Token = "0x6015585")]
	[Address(RVA = "0x16A3954", Offset = "0x16A3954", VA = "0x16A3954")]
	public UIModelUser()
	{
	}

	[Token(Token = "0x60155A1")]
	[Address(RVA = "0x16A3F68", Offset = "0x16A3F68", VA = "0x16A3F68")]
	public void SetNewbieChoice(proto.EAccount.NewbieChoice choice)
	{
	}

	[Token(Token = "0x60155A2")]
	[Address(RVA = "0x16A3FC8", Offset = "0x16A3FC8", VA = "0x16A3FC8")]
	public bool HaveDoneSinglePlayerForceTutorialGame()
	{
		return default(bool);
	}

	[Token(Token = "0x60155A3")]
	[Address(RVA = "0x16A4120", Offset = "0x16A4120", VA = "0x16A4120")]
	public void DoneSinglePlayerForceTutorialGame()
	{
	}

	[Token(Token = "0x60155A4")]
	[Address(RVA = "0x16A4668", Offset = "0x16A4668", VA = "0x16A4668")]
	public bool EnableSinglePlayerForceTutorialGame()
	{
		return default(bool);
	}

	[Token(Token = "0x60155A5")]
	[Address(RVA = "0x16A4870", Offset = "0x16A4870", VA = "0x16A4870")]
	public bool IsLastGameSinglePlayerForceTutorialGame()
	{
		return default(bool);
	}

	[Token(Token = "0x60155B1")]
	[Address(RVA = "0x16A4A98", Offset = "0x16A4A98", VA = "0x16A4A98", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x60155B2")]
	[Address(RVA = "0x16A4AF0", Offset = "0x16A4AF0", VA = "0x16A4AF0")]
	public bool IsLogin()
	{
		return default(bool);
	}

	[Token(Token = "0x60155B3")]
	[Address(RVA = "0x16A4BD0", Offset = "0x16A4BD0", VA = "0x16A4BD0")]
	public byte GetRegionIDByName(string regionName)
	{
		return default(byte);
	}

	[Token(Token = "0x60155B4")]
	[Address(RVA = "0x16A4EE4", Offset = "0x16A4EE4", VA = "0x16A4EE4", Slot = "7")]
	public override void LoginOffline()
	{
	}

	[Token(Token = "0x60155B5")]
	[Address(RVA = "0x16A4FCC", Offset = "0x16A4FCC", VA = "0x16A4FCC", Slot = "8")]
	public override void Login(object[] data)
	{
	}

	[Token(Token = "0x60155B6")]
	[Address(RVA = "0x16A6170", Offset = "0x16A6170", VA = "0x16A6170", Slot = "9")]
	public override void Logout(object[] data)
	{
	}

	[Token(Token = "0x60155B7")]
	[Address(RVA = "0x16A6254", Offset = "0x16A6254", VA = "0x16A6254")]
	public void UpdateLevelUpInfo(AccountLevelUpInfo levelUpInfo)
	{
	}

	[Token(Token = "0x60155B8")]
	[Address(RVA = "0x16A65FC", Offset = "0x16A65FC", VA = "0x16A65FC")]
	public void AfterMatch(MatchIncome inData)
	{
	}

	[Token(Token = "0x60155B9")]
	[Address(RVA = "0x16A676C", Offset = "0x16A676C", VA = "0x16A676C")]
	public void AfterQuestBackpack(AccountWallet wData)
	{
	}

	[Token(Token = "0x60155BA")]
	[Address(RVA = "0x16A6854", Offset = "0x16A6854", VA = "0x16A6854")]
	public void RefreshUserResource(uint coins, int gems)
	{
	}

	[Token(Token = "0x60155BB")]
	[Address(RVA = "0x16A69EC", Offset = "0x16A69EC", VA = "0x16A69EC")]
	public void RefreshUserResourceByDeltaValue(int deltaCoins, int deltaGem)
	{
	}

	[Token(Token = "0x60155BC")]
	[Address(RVA = "0x16A6A84", Offset = "0x16A6A84", VA = "0x16A6A84")]
	public void SetClanID(ulong clanid)
	{
	}

	[Token(Token = "0x60155BD")]
	[Address(RVA = "0x16A7258", Offset = "0x16A7258", VA = "0x16A7258")]
	public void UserRename(string new_name, bool useCard)
	{
	}

	[Token(Token = "0x60155BE")]
	[Address(RVA = "0x16A74B8", Offset = "0x16A74B8", VA = "0x16A74B8")]
	public void CheckCdKey(string email, string key)
	{
	}

	[Token(Token = "0x60155BF")]
	[Address(RVA = "0x16A77A4", Offset = "0x16A77A4", VA = "0x16A77A4")]
	public void UpdateUserRole(AccountRoleInfo roleInfo)
	{
	}

	[Token(Token = "0x60155C0")]
	[Address(RVA = "0x16A7B00", Offset = "0x16A7B00", VA = "0x16A7B00")]
	public bool IsUGCUser()
	{
		return default(bool);
	}

	[Token(Token = "0x60155C1")]
	[Address(RVA = "0x16A7B58", Offset = "0x16A7B58", VA = "0x16A7B58")]
	public int GetUserGameDays()
	{
		return default(int);
	}

	[Token(Token = "0x60155C2")]
	[Address(RVA = "0x16A5EC0", Offset = "0x16A5EC0", VA = "0x16A5EC0")]
	private void ResizeResolutionByRegion(string region)
	{
	}

	[Token(Token = "0x60155C3")]
	[Address(RVA = "0x16A7CC0", Offset = "0x16A7CC0", VA = "0x16A7CC0")]
	public string GetAccountIdEnc()
	{
		return null;
	}

	[Token(Token = "0x60155C4")]
	[Address(RVA = "0x16A7DA8", Offset = "0x16A7DA8", VA = "0x16A7DA8")]
	private string GetAccountIdEnc(int idx)
	{
		return null;
	}

	[Token(Token = "0x60155C5")]
	[Address(RVA = "0x16A8384", Offset = "0x16A8384", VA = "0x16A8384")]
	private string GetDynamicKey(int idx)
	{
		return null;
	}

	[Token(Token = "0x60155C6")]
	[Address(RVA = "0x16A8714", Offset = "0x16A8714", VA = "0x16A8714")]
	public void SaveLocalNewbieVeteranChoice(proto.EAccount.NewbieChoice registerCheckNewbieVeteran)
	{
	}

	[Token(Token = "0x60155C7")]
	[Address(RVA = "0x16A87FC", Offset = "0x16A87FC", VA = "0x16A87FC")]
	public proto.EAccount.NewbieChoice ReadLocalNewbieVeteranChoice()
	{
		return default(proto.EAccount.NewbieChoice);
	}

	[Token(Token = "0x60155C8")]
	[Address(RVA = "0x16A88DC", Offset = "0x16A88DC", VA = "0x16A88DC")]
	public bool IsNeedSinglePlayerForceTutorial()
	{
		return default(bool);
	}

	[Token(Token = "0x60155C9")]
	[Address(RVA = "0x16A8968", Offset = "0x16A8968", VA = "0x16A8968")]
	public bool HaveCompleteSinglePlayerForceTutorial()
	{
		return default(bool);
	}

	[Token(Token = "0x60155CA")]
	[Address(RVA = "0x16A89CC", Offset = "0x16A89CC", VA = "0x16A89CC")]
	public bool IsNeedTutorialBR()
	{
		return default(bool);
	}

	[Token(Token = "0x60155CB")]
	[Address(RVA = "0x16A8A58", Offset = "0x16A8A58", VA = "0x16A8A58")]
	public bool IsNeedFirstGuideMatch()
	{
		return default(bool);
	}

	[Token(Token = "0x60155CC")]
	[Address(RVA = "0x16A8AE4", Offset = "0x16A8AE4", VA = "0x16A8AE4")]
	public void SaveRegisterFlow(RegisterFlowBit bit, ulong accountId = 0uL)
	{
	}

	[Token(Token = "0x60155CD")]
	[Address(RVA = "0x16A46CC", Offset = "0x16A46CC", VA = "0x16A46CC")]
	public bool ReadRegisterFlow(RegisterFlowBit bit)
	{
		return default(bool);
	}

	[Token(Token = "0x60155CE")]
	[Address(RVA = "0x16A8D00", Offset = "0x16A8D00", VA = "0x16A8D00")]
	public void GetLadderMatchLeaderBoardRank()
	{
	}

	[Token(Token = "0x60155D0")]
	[Address(RVA = "0x16A9058", Offset = "0x16A9058", VA = "0x16A9058")]
	private static DisconnectedReason _003CLogin_003Em__0(TCPMsgPacket packet)
	{
		return default(DisconnectedReason);
	}

	[Token(Token = "0x60155D1")]
	[Address(RVA = "0x16A9564", Offset = "0x16A9564", VA = "0x16A9564")]
	private void _003CUserRename_003Em__1(HttpErrorCode errorCode, object obj)
	{
	}

	[Token(Token = "0x60155D2")]
	[Address(RVA = "0x16A9C08", Offset = "0x16A9C08", VA = "0x16A9C08")]
	private void _003CCheckCdKey_003Em__2(HttpErrorCode errorCode, object obj)
	{
	}

	[Token(Token = "0x60155D3")]
	[Address(RVA = "0x16AA0FC", Offset = "0x16AA0FC", VA = "0x16AA0FC")]
	private static void _003CGetLadderMatchLeaderBoardRank_003Em__3(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x60155D4")]
	[Address(RVA = "0x16AA100", Offset = "0x16AA100", VA = "0x16AA100")]
	public void _003C_003EiFixBaseProxy_LoginOffline()
	{
	}

	[Token(Token = "0x60155D5")]
	[Address(RVA = "0x16AA108", Offset = "0x16AA108", VA = "0x16AA108")]
	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}

	[Token(Token = "0x60155D6")]
	[Address(RVA = "0x16AA110", Offset = "0x16AA110", VA = "0x16AA110")]
	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
