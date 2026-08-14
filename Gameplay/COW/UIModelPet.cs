using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;
using tcp;

namespace COW;

[Token(Token = "0x20031CD")]
internal class UIModelPet : UIBaseModel
{
	[Token(Token = "0x20031CE")]
	private sealed class _003CGetAllPetList_003Ec__AnonStorey0
	{
		[Token(Token = "0x4012F76")]
		[FieldOffset(Offset = "0x8")]
		internal PetData petCfg;

		[Token(Token = "0x6015063")]
		[Address(RVA = "0x312E3A4", Offset = "0x312E3A4", VA = "0x312E3A4")]
		public _003CGetAllPetList_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6015064")]
		[Address(RVA = "0x312E3AC", Offset = "0x312E3AC", VA = "0x312E3AC")]
		internal bool _003C_003Em__0(proto.PetInfo temp)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20031CF")]
	private sealed class _003CSelectPet_003Ec__AnonStorey1
	{
		[Token(Token = "0x4012F77")]
		[FieldOffset(Offset = "0x8")]
		internal uint pet_id;

		[Token(Token = "0x4012F78")]
		[FieldOffset(Offset = "0xC")]
		internal bool carry_state;

		[Token(Token = "0x4012F79")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelPet _0024this;

		[Token(Token = "0x4012F7A")]
		[FieldOffset(Offset = "0x0")]
		private static Predicate<proto.PetInfo> _003C_003Ef__am_0024cache0;

		[Token(Token = "0x4012F7B")]
		[FieldOffset(Offset = "0x4")]
		private static Predicate<proto.PetInfo> _003C_003Ef__am_0024cache1;

		[Token(Token = "0x6015065")]
		[Address(RVA = "0x312E9D8", Offset = "0x312E9D8", VA = "0x312E9D8")]
		public _003CSelectPet_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x6015066")]
		[Address(RVA = "0x312E9E0", Offset = "0x312E9E0", VA = "0x312E9E0")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}

		[Token(Token = "0x6015067")]
		[Address(RVA = "0x312F80C", Offset = "0x312F80C", VA = "0x312F80C")]
		private static bool _003C_003Em__1(proto.PetInfo temp)
		{
			return default(bool);
		}

		[Token(Token = "0x6015068")]
		[Address(RVA = "0x312F828", Offset = "0x312F828", VA = "0x312F828")]
		internal bool _003C_003Em__2(proto.PetInfo temp)
		{
			return default(bool);
		}

		[Token(Token = "0x6015069")]
		[Address(RVA = "0x312F84C", Offset = "0x312F84C", VA = "0x312F84C")]
		private static bool _003C_003Em__3(proto.PetInfo temp)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20031D0")]
	private sealed class _003CFeedPet_003Ec__AnonStorey2
	{
		[Token(Token = "0x4012F7C")]
		[FieldOffset(Offset = "0x8")]
		internal uint pet_id;

		[Token(Token = "0x4012F7D")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelPet _0024this;

		[Token(Token = "0x601506A")]
		[Address(RVA = "0x312DFB8", Offset = "0x312DFB8", VA = "0x312DFB8")]
		public _003CFeedPet_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x601506B")]
		[Address(RVA = "0x312DFC0", Offset = "0x312DFC0", VA = "0x312DFC0")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}

		[Token(Token = "0x601506C")]
		[Address(RVA = "0x312E36C", Offset = "0x312E36C", VA = "0x312E36C")]
		internal bool _003C_003Em__1(proto.PetInfo temp)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20031D1")]
	private sealed class _003COnReceivedFeedData_003Ec__AnonStorey3
	{
		[Token(Token = "0x4012F7E")]
		[FieldOffset(Offset = "0x8")]
		internal PetLevelUpNtf data;

		[Token(Token = "0x601506D")]
		[Address(RVA = "0x312E3F8", Offset = "0x312E3F8", VA = "0x312E3F8")]
		public _003COnReceivedFeedData_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x601506E")]
		[Address(RVA = "0x312E400", Offset = "0x312E400", VA = "0x312E400")]
		internal bool _003C_003Em__0(proto.PetInfo temp)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20031D2")]
	private sealed class _003CRenamePet_003Ec__AnonStorey4
	{
		[Token(Token = "0x4012F7F")]
		[FieldOffset(Offset = "0x8")]
		internal uint pet_id;

		[Token(Token = "0x4012F80")]
		[FieldOffset(Offset = "0xC")]
		internal UIModelPet _0024this;

		[Token(Token = "0x601506F")]
		[Address(RVA = "0x312E458", Offset = "0x312E458", VA = "0x312E458")]
		public _003CRenamePet_003Ec__AnonStorey4()
		{
		}

		[Token(Token = "0x6015070")]
		[Address(RVA = "0x312E460", Offset = "0x312E460", VA = "0x312E460")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}

		[Token(Token = "0x6015071")]
		[Address(RVA = "0x312E9A0", Offset = "0x312E9A0", VA = "0x312E9A0")]
		internal bool _003C_003Em__1(proto.PetInfo temp)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20031D3")]
	private sealed class _003CSelectPetSkin_003Ec__AnonStorey5
	{
		[Token(Token = "0x4012F81")]
		[FieldOffset(Offset = "0x8")]
		internal uint pet_id;

		[Token(Token = "0x4012F82")]
		[FieldOffset(Offset = "0xC")]
		internal uint skin_id;

		[Token(Token = "0x4012F83")]
		[FieldOffset(Offset = "0x10")]
		internal bool notifyCommonReward;

		[Token(Token = "0x4012F84")]
		[FieldOffset(Offset = "0x14")]
		internal UIModelPet _0024this;

		[Token(Token = "0x6015072")]
		[Address(RVA = "0x312FACC", Offset = "0x312FACC", VA = "0x312FACC")]
		public _003CSelectPetSkin_003Ec__AnonStorey5()
		{
		}

		[Token(Token = "0x6015073")]
		[Address(RVA = "0x312FAD4", Offset = "0x312FAD4", VA = "0x312FAD4")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}

		[Token(Token = "0x6015074")]
		[Address(RVA = "0x3130244", Offset = "0x3130244", VA = "0x3130244")]
		internal bool _003C_003Em__1(proto.PetInfo temp)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20031D4")]
	private sealed class _003CSelectPetSkill_003Ec__AnonStorey6
	{
		[Token(Token = "0x4012F85")]
		[FieldOffset(Offset = "0x8")]
		internal uint pet_id;

		[Token(Token = "0x4012F86")]
		[FieldOffset(Offset = "0xC")]
		internal uint pet_skill_id;

		[Token(Token = "0x4012F87")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelPet _0024this;

		[Token(Token = "0x6015075")]
		[Address(RVA = "0x312F868", Offset = "0x312F868", VA = "0x312F868")]
		public _003CSelectPetSkill_003Ec__AnonStorey6()
		{
		}

		[Token(Token = "0x6015076")]
		[Address(RVA = "0x312F870", Offset = "0x312F870", VA = "0x312F870")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object res)
		{
		}

		[Token(Token = "0x6015077")]
		[Address(RVA = "0x312FA94", Offset = "0x312FA94", VA = "0x312FA94")]
		internal bool _003C_003Em__1(proto.PetInfo temp)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20031D5")]
	private sealed class _003CUpdateNewItem_003Ec__AnonStorey7
	{
		[Token(Token = "0x4012F88")]
		[FieldOffset(Offset = "0x8")]
		internal PetSkinData SkinData;

		[Token(Token = "0x6015078")]
		[Address(RVA = "0x313027C", Offset = "0x313027C", VA = "0x313027C")]
		public _003CUpdateNewItem_003Ec__AnonStorey7()
		{
		}

		[Token(Token = "0x6015079")]
		[Address(RVA = "0x3130284", Offset = "0x3130284", VA = "0x3130284")]
		internal bool _003C_003Em__0(proto.PetInfo temp)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4012F5C")]
	public const uint PropID_UpdatePetExp = 2u;

	[Token(Token = "0x4012F5D")]
	public const uint PropID_UpdatePetCarry = 4u;

	[Token(Token = "0x4012F5E")]
	public const uint PropID_UpdatePetInfo = 8u;

	[Token(Token = "0x4012F5F")]
	public const uint PropID_RenameSuccess = 16u;

	[Token(Token = "0x4012F60")]
	public const uint PropID_RenameError = 32u;

	[Token(Token = "0x4012F61")]
	public const uint PropID_UpdatePetFeed = 64u;

	[Token(Token = "0x4012F62")]
	public const uint PropID_PetInfoLevelUp = 128u;

	[Token(Token = "0x4012F63")]
	public const uint PropID_PetActionListGet = 256u;

	[Token(Token = "0x4012F64")]
	public const uint PropID_PetSkinListGet = 512u;

	[Token(Token = "0x4012F65")]
	public const uint PropID_PetSkinSelected = 1024u;

	[Token(Token = "0x4012F66")]
	public const uint PropID_PetSkillListGet = 2048u;

	[Token(Token = "0x4012F67")]
	public const uint PropID_PetNewTagChange = 4096u;

	[Token(Token = "0x4012F68")]
	public const uint PropID_PetSkillSelected = 8192u;

	[Token(Token = "0x4012F69")]
	public const uint PropID_UpdatePetCarryFailed = 16384u;

	[Token(Token = "0x4012F6A")]
	[FieldOffset(Offset = "0xC")]
	private proto.PetInfo m_CarryPetInfo;

	[Token(Token = "0x4012F6B")]
	[FieldOffset(Offset = "0x10")]
	private PetLevelUpNtf last_exp_data;

	[Token(Token = "0x4012F6C")]
	[FieldOffset(Offset = "0x14")]
	private proto.PetInfo m_CurrentSelectedPetInfo;

	[Token(Token = "0x4012F6D")]
	[FieldOffset(Offset = "0x18")]
	private uint m_CurrentSelectedPetSkinID;

	[Token(Token = "0x4012F6E")]
	[FieldOffset(Offset = "0x1C")]
	private bool isShowPetPanel;

	[Token(Token = "0x4012F6F")]
	[FieldOffset(Offset = "0x20")]
	private List<proto.PetInfo> _003COwnPetList_003Ek__BackingField;

	[Token(Token = "0x4012F70")]
	[FieldOffset(Offset = "0x24")]
	private List<proto.PetInfo> _003CAllPetList_003Ek__BackingField;

	[Token(Token = "0x4012F71")]
	[FieldOffset(Offset = "0x28")]
	private List<uint> m_newTagList;

	[Token(Token = "0x4012F72")]
	[FieldOffset(Offset = "0x2C")]
	private List<PetActionInfo> _003COwnActionList_003Ek__BackingField;

	[Token(Token = "0x4012F73")]
	[FieldOffset(Offset = "0x30")]
	private List<PetSkinInfo> _003COwnSkinList_003Ek__BackingField;

	[Token(Token = "0x4012F74")]
	[FieldOffset(Offset = "0x34")]
	private List<proto.PetSkillInfo> _003COwnSkillList_003Ek__BackingField;

	[Token(Token = "0x4012F75")]
	[FieldOffset(Offset = "0x0")]
	private static Predicate<proto.PetInfo> _003C_003Ef__am_0024cache0;

	[Token(Token = "0x17001629")]
	public List<proto.PetInfo> OwnPetList
	{
		[Token(Token = "0x6015024")]
		[Address(RVA = "0x31CB13C", Offset = "0x31CB13C", VA = "0x31CB13C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6015025")]
		[Address(RVA = "0x31CB144", Offset = "0x31CB144", VA = "0x31CB144")]
		private set
		{
		}
	}

	[Token(Token = "0x1700162A")]
	public List<proto.PetInfo> AllPetList
	{
		[Token(Token = "0x6015026")]
		[Address(RVA = "0x31CB14C", Offset = "0x31CB14C", VA = "0x31CB14C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6015027")]
		[Address(RVA = "0x31CB154", Offset = "0x31CB154", VA = "0x31CB154")]
		private set
		{
		}
	}

	[Token(Token = "0x1700162B")]
	public List<PetActionInfo> OwnActionList
	{
		[Token(Token = "0x6015028")]
		[Address(RVA = "0x31CB15C", Offset = "0x31CB15C", VA = "0x31CB15C")]
		get
		{
			return null;
		}
		[Token(Token = "0x6015029")]
		[Address(RVA = "0x31CB164", Offset = "0x31CB164", VA = "0x31CB164")]
		private set
		{
		}
	}

	[Token(Token = "0x1700162C")]
	public List<PetSkinInfo> OwnSkinList
	{
		[Token(Token = "0x601502A")]
		[Address(RVA = "0x31CB16C", Offset = "0x31CB16C", VA = "0x31CB16C")]
		get
		{
			return null;
		}
		[Token(Token = "0x601502B")]
		[Address(RVA = "0x31CB174", Offset = "0x31CB174", VA = "0x31CB174")]
		private set
		{
		}
	}

	[Token(Token = "0x1700162D")]
	public List<proto.PetSkillInfo> OwnSkillList
	{
		[Token(Token = "0x601502C")]
		[Address(RVA = "0x31CB17C", Offset = "0x31CB17C", VA = "0x31CB17C")]
		get
		{
			return null;
		}
		[Token(Token = "0x601502D")]
		[Address(RVA = "0x31CB184", Offset = "0x31CB184", VA = "0x31CB184")]
		private set
		{
		}
	}

	[Token(Token = "0x6015022")]
	[Address(RVA = "0x31CB02C", Offset = "0x31CB02C", VA = "0x31CB02C")]
	public UIModelPet()
	{
	}

	[Token(Token = "0x6015023")]
	[Address(RVA = "0x31CB0E4", Offset = "0x31CB0E4", VA = "0x31CB0E4", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x601502E")]
	[Address(RVA = "0x31CB18C", Offset = "0x31CB18C", VA = "0x31CB18C", Slot = "4")]
	public override void Init()
	{
	}

	[Token(Token = "0x601502F")]
	[Address(RVA = "0x31CB2C8", Offset = "0x31CB2C8", VA = "0x31CB2C8")]
	public void UpdatePetCarryInfo(proto.PetInfo data)
	{
	}

	[Token(Token = "0x6015030")]
	[Address(RVA = "0x31CB558", Offset = "0x31CB558", VA = "0x31CB558")]
	public void UpdatePetInfoList(List<proto.PetInfo> list)
	{
	}

	[Token(Token = "0x6015031")]
	[Address(RVA = "0x31CBBE0", Offset = "0x31CBBE0", VA = "0x31CBBE0")]
	public void SetShowingPetPanel(bool show_state)
	{
	}

	[Token(Token = "0x6015032")]
	[Address(RVA = "0x31CBC40", Offset = "0x31CBC40", VA = "0x31CBC40")]
	public bool CheckNeedShowPetLevelUp()
	{
		return default(bool);
	}

	[Token(Token = "0x6015033")]
	[Address(RVA = "0x31CBCF0", Offset = "0x31CBCF0", VA = "0x31CBCF0")]
	public void ClearLastExpData()
	{
	}

	[Token(Token = "0x6015034")]
	[Address(RVA = "0x31CBD4C", Offset = "0x31CBD4C", VA = "0x31CBD4C")]
	public PetLevelUpNtf GetLevelUpData()
	{
		return null;
	}

	[Token(Token = "0x6015035")]
	[Address(RVA = "0x31CBDA4", Offset = "0x31CBDA4", VA = "0x31CBDA4")]
	public void SetShowNewTag(uint item_id)
	{
	}

	[Token(Token = "0x6015036")]
	[Address(RVA = "0x31CBEA8", Offset = "0x31CBEA8", VA = "0x31CBEA8")]
	public bool IsHideShowNewTag(uint item_id)
	{
		return default(bool);
	}

	[Token(Token = "0x6015037")]
	[Address(RVA = "0x31CBF78", Offset = "0x31CBF78", VA = "0x31CBF78")]
	public void RemoveNewTag(uint item_id)
	{
	}

	[Token(Token = "0x6015038")]
	[Address(RVA = "0x31CC07C", Offset = "0x31CC07C", VA = "0x31CC07C")]
	public void UpdatePetSelectedInfo(proto.PetInfo info)
	{
	}

	[Token(Token = "0x6015039")]
	[Address(RVA = "0x31CC0F8", Offset = "0x31CC0F8", VA = "0x31CC0F8")]
	public void UpdatePetSkinIDSelected(uint skinID)
	{
	}

	[Token(Token = "0x601503A")]
	[Address(RVA = "0x31CC158", Offset = "0x31CC158", VA = "0x31CC158")]
	public uint GetSelectedPetSkinID()
	{
		return default(uint);
	}

	[Token(Token = "0x601503B")]
	[Address(RVA = "0x31CC1B0", Offset = "0x31CC1B0", VA = "0x31CC1B0")]
	public proto.PetInfo GetSelectedPetInfo()
	{
		return null;
	}

	[Token(Token = "0x601503C")]
	[Address(RVA = "0x31CB6C4", Offset = "0x31CB6C4", VA = "0x31CB6C4")]
	private List<proto.PetInfo> GetAllPetList()
	{
		return null;
	}

	[Token(Token = "0x601503D")]
	[Address(RVA = "0x31CC208", Offset = "0x31CC208", VA = "0x31CC208")]
	public void CheckPetNewFlag()
	{
	}

	[Token(Token = "0x601503E")]
	[Address(RVA = "0x31CCA58", Offset = "0x31CCA58", VA = "0x31CCA58")]
	public bool CheckPetSkinNewFlag(int id, bool add_tip)
	{
		return default(bool);
	}

	[Token(Token = "0x601503F")]
	[Address(RVA = "0x31CD3C8", Offset = "0x31CD3C8", VA = "0x31CD3C8")]
	public bool CheckPetSkillFlag(int id, bool add_tip)
	{
		return default(bool);
	}

	[Token(Token = "0x6015040")]
	[Address(RVA = "0x31CCF10", Offset = "0x31CCF10", VA = "0x31CCF10")]
	public bool CheckPetActionFlag(int id, bool add_tip)
	{
		return default(bool);
	}

	[Token(Token = "0x6015041")]
	[Address(RVA = "0x31CD874", Offset = "0x31CD874", VA = "0x31CD874")]
	public List<proto.PetInfo> GetPetInfoCanShow()
	{
		return null;
	}

	[Token(Token = "0x6015042")]
	[Address(RVA = "0x31CDBF8", Offset = "0x31CDBF8", VA = "0x31CDBF8", Slot = "9")]
	public override void Logout(object[] data)
	{
	}

	[Token(Token = "0x6015043")]
	[Address(RVA = "0x31CDCE4", Offset = "0x31CDCE4", VA = "0x31CDCE4")]
	public void GetMyPetInfoData(bool force = false)
	{
	}

	[Token(Token = "0x6015044")]
	[Address(RVA = "0x31CDF64", Offset = "0x31CDF64", VA = "0x31CDF64")]
	public void NotifyPetDataRefresh()
	{
	}

	[Token(Token = "0x6015045")]
	[Address(RVA = "0x31CE0AC", Offset = "0x31CE0AC", VA = "0x31CE0AC")]
	public void SelectPet(uint pet_id, bool carry_state)
	{
	}

	[Token(Token = "0x6015046")]
	[Address(RVA = "0x31CE6C0", Offset = "0x31CE6C0", VA = "0x31CE6C0")]
	public void FeedPet(uint pet_id, uint food_id, uint food_count)
	{
	}

	[Token(Token = "0x6015047")]
	[Address(RVA = "0x31CEB18", Offset = "0x31CEB18", VA = "0x31CEB18")]
	public uint GetPetExpMaxLevel(int pet_id)
	{
		return default(uint);
	}

	[Token(Token = "0x6015048")]
	[Address(RVA = "0x31CEC5C", Offset = "0x31CEC5C", VA = "0x31CEC5C")]
	public void OnReceivedFeedData(PetLevelUpNtf data)
	{
	}

	[Token(Token = "0x6015049")]
	[Address(RVA = "0x31D015C", Offset = "0x31D015C", VA = "0x31D015C")]
	public void RenamePet(uint pet_id, string name)
	{
	}

	[Token(Token = "0x601504A")]
	[Address(RVA = "0x31D05A0", Offset = "0x31D05A0", VA = "0x31D05A0")]
	public uint GetFoodItemByPetID(uint pet_id)
	{
		return default(uint);
	}

	[Token(Token = "0x601504B")]
	[Address(RVA = "0x31D0950", Offset = "0x31D0950", VA = "0x31D0950")]
	public int GetFoodItemExpByPetID(uint pet_id)
	{
		return default(int);
	}

	[Token(Token = "0x601504C")]
	[Address(RVA = "0x31D0D00", Offset = "0x31D0D00", VA = "0x31D0D00")]
	public uint GetCurrentCarryPetID()
	{
		return default(uint);
	}

	[Token(Token = "0x601504D")]
	[Address(RVA = "0x31D0D6C", Offset = "0x31D0D6C", VA = "0x31D0D6C")]
	public bool CheckPetLockState(proto.PetInfo pet_info)
	{
		return default(bool);
	}

	[Token(Token = "0x601504E")]
	[Address(RVA = "0x31D0DE8", Offset = "0x31D0DE8", VA = "0x31D0DE8")]
	public uint GetCurrentCarryPetSkinID()
	{
		return default(uint);
	}

	[Token(Token = "0x601504F")]
	[Address(RVA = "0x31D0E54", Offset = "0x31D0E54", VA = "0x31D0E54")]
	public proto.PetInfo GetCurrentCarryPetInfo()
	{
		return null;
	}

	[Token(Token = "0x6015050")]
	[Address(RVA = "0x31CC8A4", Offset = "0x31CC8A4", VA = "0x31CC8A4")]
	public proto.PetInfo GetPetInfoById(uint m_id)
	{
		return null;
	}

	[Token(Token = "0x6015051")]
	[Address(RVA = "0x31D0EAC", Offset = "0x31D0EAC", VA = "0x31D0EAC")]
	public ResourceID GetPetResourceID(uint pet_id)
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6015052")]
	[Address(RVA = "0x31D102C", Offset = "0x31D102C", VA = "0x31D102C")]
	public ResourceID GetSkinResourceID(uint skin_id)
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6015053")]
	[Address(RVA = "0x31D11AC", Offset = "0x31D11AC", VA = "0x31D11AC")]
	public PetConfigInfo GetNextPetConfigByID(uint pet_id, uint Lv)
	{
		return default(PetConfigInfo);
	}

	[Token(Token = "0x6015054")]
	[Address(RVA = "0x31D1254", Offset = "0x31D1254", VA = "0x31D1254")]
	public PetConfigInfo GetCurrentPetConfigByID(uint pet_id, uint Lv)
	{
		return default(PetConfigInfo);
	}

	[Token(Token = "0x6015055")]
	[Address(RVA = "0x31CC5AC", Offset = "0x31CC5AC", VA = "0x31CC5AC")]
	public List<PetData> GetPetConfigList()
	{
		return null;
	}

	[Token(Token = "0x6015056")]
	[Address(RVA = "0x31D12FC", Offset = "0x31D12FC", VA = "0x31D12FC")]
	public PetData GetPetDataByID(uint pet_id)
	{
		return null;
	}

	[Token(Token = "0x6015057")]
	[Address(RVA = "0x31D1428", Offset = "0x31D1428", VA = "0x31D1428")]
	public List<PetActionData> GetUnlockPetAnims(uint petid)
	{
		return null;
	}

	[Token(Token = "0x6015058")]
	[Address(RVA = "0x31D1754", Offset = "0x31D1754", VA = "0x31D1754")]
	public string GetDefaultNameByID(uint pet_id)
	{
		return null;
	}

	[Token(Token = "0x6015059")]
	[Address(RVA = "0x31D195C", Offset = "0x31D195C", VA = "0x31D195C")]
	public void SelectPetSkin(uint skin_id, uint pet_id, bool notifyCommonReward = false)
	{
	}

	[Token(Token = "0x601505A")]
	[Address(RVA = "0x31D21EC", Offset = "0x31D21EC", VA = "0x31D21EC")]
	public void SelectPetSkill(uint pet_id, uint pet_skill_id)
	{
	}

	[Token(Token = "0x601505B")]
	[Address(RVA = "0x31D27CC", Offset = "0x31D27CC", VA = "0x31D27CC")]
	public void UpdateNewItem(Item[] newInventories)
	{
	}

	[Token(Token = "0x601505C")]
	[Address(RVA = "0x31D2E54", Offset = "0x31D2E54", VA = "0x31D2E54")]
	public List<ResourceID> GetCurrentCarryPetResourceIds()
	{
		return null;
	}

	[Token(Token = "0x601505D")]
	[Address(RVA = "0x31D3564", Offset = "0x31D3564", VA = "0x31D3564")]
	public List<ResourceID> GetAllOwnedPetRelativeResource()
	{
		return null;
	}

	[Token(Token = "0x601505E")]
	[Address(RVA = "0x31D40B8", Offset = "0x31D40B8", VA = "0x31D40B8")]
	private List<ResourceID> GetPetRelativesResIds(List<proto.PetInfo> PetInfos)
	{
		return null;
	}

	[Token(Token = "0x601505F")]
	[Address(RVA = "0x31D4A28", Offset = "0x31D4A28", VA = "0x31D4A28")]
	private static bool _003CUpdatePetInfoList_003Em__0(proto.PetInfo temp)
	{
		return default(bool);
	}

	[Token(Token = "0x6015060")]
	[Address(RVA = "0x31D4A4C", Offset = "0x31D4A4C", VA = "0x31D4A4C")]
	private void _003CGetMyPetInfoData_003Em__1(HttpErrorCode errorCode, object res)
	{
	}

	[Token(Token = "0x6015061")]
	[Address(RVA = "0x31D4BB4", Offset = "0x31D4BB4", VA = "0x31D4BB4")]
	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	[Token(Token = "0x6015062")]
	[Address(RVA = "0x31D4BBC", Offset = "0x31D4BBC", VA = "0x31D4BBC")]
	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
