using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;
using tcp;

namespace COW;

[Token(Token = "0x2002A52")]
public class UIPetInfoController : UIPreviewNavigationController, _Attribute, IConvertible
{
	[Token(Token = "0x2002A53")]
	private sealed class _003CGotoPet_003Ec__AnonStorey1
	{
		[Token(Token = "0x4010436")]
		[FieldOffset(Offset = "0x8")]
		internal object[] param;

		[Token(Token = "0x6011354")]
		[Address(RVA = "0x2C4629C", Offset = "0x2C4629C", VA = "0x2C4629C")]
		public _003CGotoPet_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x6011355")]
		[Address(RVA = "0x2C462A4", Offset = "0x2C462A4", VA = "0x2C462A4")]
		internal bool _003C_003Em__0(proto.PetInfo temp)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002A54")]
	private sealed class _003CProgressBarAnimation_003Ec__Iterator0 : _Attribute, IConvertible, IComparable<int>
	{
		[Token(Token = "0x4010437")]
		[FieldOffset(Offset = "0x8")]
		internal PetConfigInfo _003CconfigInfo_next_003E__1;

		[Token(Token = "0x4010438")]
		[FieldOffset(Offset = "0x2C")]
		internal PetConfigInfo _003CconfigInfo_now_003E__1;

		[Token(Token = "0x4010439")]
		[FieldOffset(Offset = "0x50")]
		internal float _003CprogressMax_003E__1;

		[Token(Token = "0x401043A")]
		[FieldOffset(Offset = "0x54")]
		internal float _003CprogressValue_003E__1;

		[Token(Token = "0x401043B")]
		[FieldOffset(Offset = "0x58")]
		internal UIPetInfoController _0024this;

		[Token(Token = "0x401043C")]
		[FieldOffset(Offset = "0x5C")]
		internal object _0024current;

		[Token(Token = "0x401043D")]
		[FieldOffset(Offset = "0x60")]
		internal bool _0024disposing;

		[Token(Token = "0x401043E")]
		[FieldOffset(Offset = "0x64")]
		internal int _0024PC;

		[Token(Token = "0x170012C3")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003Cobject_003E_002ECurrent
		{
			[Token(Token = "0x6011358")]
			[Address(RVA = "0x2C46B84", Offset = "0x2C46B84", VA = "0x2C46B84", Slot = "8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170012C4")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6011359")]
			[Address(RVA = "0x2C46B8C", Offset = "0x2C46B8C", VA = "0x2C46B8C", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6011356")]
		[Address(RVA = "0x2C46368", Offset = "0x2C46368", VA = "0x2C46368")]
		public _003CProgressBarAnimation_003Ec__Iterator0()
		{
		}

		[Token(Token = "0x6011357")]
		[Address(RVA = "0x2C46370", Offset = "0x2C46370", VA = "0x2C46370", Slot = "5")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x601135A")]
		[Address(RVA = "0x2C46B94", Offset = "0x2C46B94", VA = "0x2C46B94", Slot = "7")]
		public void Dispose()
		{
		}

		[Token(Token = "0x601135B")]
		[Address(RVA = "0x2C46BA8", Offset = "0x2C46BA8", VA = "0x2C46BA8", Slot = "6")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x2002A55")]
	private sealed class _003CShowActionList_003Ec__AnonStorey2
	{
		[Token(Token = "0x401043F")]
		[FieldOffset(Offset = "0x8")]
		internal PetActionData data;

		[Token(Token = "0x601135C")]
		[Address(RVA = "0x2C46C30", Offset = "0x2C46C30", VA = "0x2C46C30")]
		public _003CShowActionList_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x601135D")]
		[Address(RVA = "0x2C46C38", Offset = "0x2C46C38", VA = "0x2C46C38")]
		internal bool _003C_003Em__0(PetActionInfo temp)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002A56")]
	private sealed class _003CShowSkinList_003Ec__AnonStorey3
	{
		[Token(Token = "0x4010440")]
		[FieldOffset(Offset = "0x8")]
		internal PetSkinData data;

		[Token(Token = "0x601135E")]
		[Address(RVA = "0x2C46C84", Offset = "0x2C46C84", VA = "0x2C46C84")]
		public _003CShowSkinList_003Ec__AnonStorey3()
		{
		}

		[Token(Token = "0x601135F")]
		[Address(RVA = "0x2C46C8C", Offset = "0x2C46C8C", VA = "0x2C46C8C")]
		internal bool _003C_003Em__0(PetSkinInfo temp)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002A57")]
	private sealed class _003CShowSkinList_003Ec__AnonStorey5
	{
		[Token(Token = "0x4010441")]
		[FieldOffset(Offset = "0x8")]
		internal proto.PetInfo info;

		[Token(Token = "0x6011360")]
		[Address(RVA = "0x2C46D98", Offset = "0x2C46D98", VA = "0x2C46D98")]
		public _003CShowSkinList_003Ec__AnonStorey5()
		{
		}

		[Token(Token = "0x6011361")]
		[Address(RVA = "0x2C46DA0", Offset = "0x2C46DA0", VA = "0x2C46DA0")]
		internal bool _003C_003Em__0(PetSkinData temp)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2002A58")]
	private sealed class _003CShowSkinList_003Ec__AnonStorey4
	{
		[Token(Token = "0x4010442")]
		[FieldOffset(Offset = "0x8")]
		internal PetData data;

		[Token(Token = "0x6011362")]
		[Address(RVA = "0x2C46CD8", Offset = "0x2C46CD8", VA = "0x2C46CD8")]
		public _003CShowSkinList_003Ec__AnonStorey4()
		{
		}

		[Token(Token = "0x6011363")]
		[Address(RVA = "0x2C46CE0", Offset = "0x2C46CE0", VA = "0x2C46CE0")]
		internal bool _003C_003Em__0(PetSkinData temp)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x401041E")]
	[FieldOffset(Offset = "0x7C")]
	private UIPetView m_View;

	[Token(Token = "0x401041F")]
	private const string PET_RENAME_TAG = "PET_ITEM_NEW_TAG";

	[Token(Token = "0x4010420")]
	private const string PET_SELECT_SKILL_TAG = "PET_SKILL_SELECT_TAG";

	[Token(Token = "0x4010421")]
	private const string PET_FOOD_SUFFICIENT = "[FFB300FF]{0}[-]/{1}";

	[Token(Token = "0x4010422")]
	private const string PET_FOOD_INSUFFICIENT = "[EF3030FF]{0}[-]/{1}";

	[Token(Token = "0x4010423")]
	[FieldOffset(Offset = "0x80")]
	private uint current_show_pet_id;

	[Token(Token = "0x4010424")]
	[FieldOffset(Offset = "0x84")]
	private uint current_show_skin_id;

	[Token(Token = "0x4010425")]
	[FieldOffset(Offset = "0x88")]
	private UIModelPet m_PetModel;

	[Token(Token = "0x4010426")]
	[FieldOffset(Offset = "0x8C")]
	private UIPetAvatar pet_avatar;

	[Token(Token = "0x4010427")]
	[FieldOffset(Offset = "0x90")]
	private Item current_use_food;

	[Token(Token = "0x4010428")]
	[FieldOffset(Offset = "0x94")]
	private int anim_start_level;

	[Token(Token = "0x4010429")]
	[FieldOffset(Offset = "0x98")]
	private int anim_start_exp;

	[Token(Token = "0x401042A")]
	[FieldOffset(Offset = "0x9C")]
	private float anim_current_exp;

	[Token(Token = "0x401042B")]
	[FieldOffset(Offset = "0xA0")]
	private int anim_end_exp;

	[Token(Token = "0x401042C")]
	[FieldOffset(Offset = "0xA4")]
	private int anim_current_level;

	[Token(Token = "0x401042D")]
	[FieldOffset(Offset = "0xA8")]
	private bool anim_start_flag;

	[Token(Token = "0x401042E")]
	[FieldOffset(Offset = "0xAC")]
	private float anim_speed;

	[Token(Token = "0x401042F")]
	[FieldOffset(Offset = "0xB0")]
	private UIShowType Show_grid_flag;

	[Token(Token = "0x4010430")]
	[FieldOffset(Offset = "0xB4")]
	private uint max_feed_count;

	[Token(Token = "0x4010431")]
	[FieldOffset(Offset = "0xB8")]
	private uint next_level_feed_count;

	[Token(Token = "0x4010432")]
	[FieldOffset(Offset = "0xBC")]
	private UIPetNormalGridController m_normalGridController;

	[Token(Token = "0x4010433")]
	[FieldOffset(Offset = "0xC0")]
	private UIPetSkillGridController m_skillGridController;

	[Token(Token = "0x4010434")]
	[FieldOffset(Offset = "0xC4")]
	private UICommonGuideController m_PetLevelUpGuide;

	[Token(Token = "0x4010435")]
	[FieldOffset(Offset = "0xC8")]
	private UIUtils.ScreenshotType m_CurrentScreenshotType;

	[Token(Token = "0x6011301")]
	[Address(RVA = "0x23F4DE0", Offset = "0x23F4DE0", VA = "0x23F4DE0")]
	public UIPetInfoController()
	{
	}

	[Token(Token = "0x6011302")]
	[Address(RVA = "0x23F4E04", Offset = "0x23F4E04", VA = "0x23F4E04", Slot = "67")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6011303")]
	[Address(RVA = "0x23F4EE0", Offset = "0x23F4EE0", VA = "0x23F4EE0", Slot = "66")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6011304")]
	[Address(RVA = "0x23F6F9C", Offset = "0x23F6F9C", VA = "0x23F6F9C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011305")]
	[Address(RVA = "0x23F7044", Offset = "0x23F7044", VA = "0x23F7044", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011306")]
	[Address(RVA = "0x23F8854", Offset = "0x23F8854", VA = "0x23F8854")]
	private void OnActionBtnClick()
	{
	}

	[Token(Token = "0x6011307")]
	[Address(RVA = "0x23F8B8C", Offset = "0x23F8B8C", VA = "0x23F8B8C")]
	private void OnSkinBtnClick()
	{
	}

	[Token(Token = "0x6011308")]
	[Address(RVA = "0x23F8E58", Offset = "0x23F8E58", VA = "0x23F8E58")]
	private void OnSkillBtnClick()
	{
	}

	[Token(Token = "0x6011309")]
	[Address(RVA = "0x23F7F88", Offset = "0x23F7F88", VA = "0x23F7F88")]
	private void SetTitleBtnState(UIShowType type)
	{
	}

	[Token(Token = "0x601130A")]
	[Address(RVA = "0x23F90AC", Offset = "0x23F90AC", VA = "0x23F90AC")]
	private void PlayAnimation(object[] param)
	{
	}

	[Token(Token = "0x601130B")]
	[Address(RVA = "0x23F9BC8", Offset = "0x23F9BC8", VA = "0x23F9BC8")]
	private void ChangeSkin(object[] param)
	{
	}

	[Token(Token = "0x601130C")]
	[Address(RVA = "0x23F9D48", Offset = "0x23F9D48", VA = "0x23F9D48")]
	private void ChangeSelectSkill(object[] param)
	{
	}

	[Token(Token = "0x601130D")]
	[Address(RVA = "0x23F9408", Offset = "0x23F9408", VA = "0x23F9408")]
	private void RefreshInfoContainer(CSSharedItemData inventoryItem)
	{
	}

	[Token(Token = "0x601130E")]
	[Address(RVA = "0x23F6C9C", Offset = "0x23F6C9C", VA = "0x23F6C9C")]
	private void LevelUpShow()
	{
	}

	[Token(Token = "0x601130F")]
	[Address(RVA = "0x23F9EC4", Offset = "0x23F9EC4", VA = "0x23F9EC4")]
	private void RefreshPriviewUIShow()
	{
	}

	[Token(Token = "0x6011310")]
	[Address(RVA = "0x23FA0D8", Offset = "0x23FA0D8", VA = "0x23FA0D8")]
	protected void HighLightItem(int itemIndex, UIEasyList grid, bool needClick = false, bool showTips = false)
	{
	}

	[Token(Token = "0x6011311")]
	[Address(RVA = "0x23FA3FC", Offset = "0x23FA3FC", VA = "0x23FA3FC", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x6011312")]
	[Address(RVA = "0x23F5CD8", Offset = "0x23F5CD8", VA = "0x23F5CD8")]
	private void RefreshPetList()
	{
	}

	[Token(Token = "0x6011313")]
	[Address(RVA = "0x23FA460", Offset = "0x23FA460", VA = "0x23FA460")]
	private void OnBuyPetClick()
	{
	}

	[Token(Token = "0x6011314")]
	[Address(RVA = "0x23FA6A0", Offset = "0x23FA6A0", VA = "0x23FA6A0")]
	private void BuyPet()
	{
	}

	[Token(Token = "0x6011315")]
	[Address(RVA = "0x23F6CF0", Offset = "0x23F6CF0", VA = "0x23F6CF0")]
	public void CheckNewTag(object[] param)
	{
	}

	[Token(Token = "0x6011316")]
	[Address(RVA = "0x23F8AFC", Offset = "0x23F8AFC", VA = "0x23F8AFC")]
	private void ResetItemInfoShow()
	{
	}

	[Token(Token = "0x6011317")]
	[Address(RVA = "0x23FAC3C", Offset = "0x23FAC3C", VA = "0x23FAC3C")]
	private void GotoPet(object[] param)
	{
	}

	[Token(Token = "0x6011318")]
	[Address(RVA = "0x23FAFB8", Offset = "0x23FAFB8", VA = "0x23FAFB8")]
	private void RefreshDownLoadState(object[] param)
	{
	}

	[Token(Token = "0x6011319")]
	[Address(RVA = "0x23FB100", Offset = "0x23FB100", VA = "0x23FB100")]
	private void SetSelectBtnShow(object[] param)
	{
	}

	[Token(Token = "0x601131A")]
	[Address(RVA = "0x23FB23C", Offset = "0x23FB23C", VA = "0x23FB23C")]
	private void RecoverLevelUpBtnState(object[] param)
	{
	}

	[Token(Token = "0x601131B")]
	[Address(RVA = "0x23FB2A8", Offset = "0x23FB2A8", VA = "0x23FB2A8")]
	private void RefreshPetInfoPanel(object[] param)
	{
	}

	[Token(Token = "0x601131C")]
	[Address(RVA = "0x23F69C4", Offset = "0x23F69C4", VA = "0x23F69C4")]
	private void ShowGridInfoList(PetConfigInfo config, bool selectByInfoIfNeed = true)
	{
	}

	[Token(Token = "0x601131D")]
	[Address(RVA = "0x23F6484", Offset = "0x23F6484", VA = "0x23F6484")]
	private void RefreshPetExpLabel(PetLevelUpNtf data)
	{
	}

	[Token(Token = "0x601131E")]
	[Address(RVA = "0x23FC10C", Offset = "0x23FC10C", VA = "0x23FC10C")]
	private void RefreshMyPetInfoComponent(bool showFlag)
	{
	}

	[Token(Token = "0x601131F")]
	[Address(RVA = "0x23F65C8", Offset = "0x23F65C8", VA = "0x23F65C8")]
	private void RefreshMyPetFoodComponent()
	{
	}

	[Token(Token = "0x6011320")]
	[Address(RVA = "0x23FC518", Offset = "0x23FC518", VA = "0x23FC518")]
	private void UpdateProgressBar(int exp_own, int exp_lvUp)
	{
	}

	[Token(Token = "0x6011321")]
	[Address(RVA = "0x23FD44C", Offset = "0x23FD44C", VA = "0x23FD44C")]
	private void UpdateProgressBarAnim(int exp_old, int exp_own, int start_lv, int end_lv)
	{
	}

	[Token(Token = "0x6011322")]
	[Address(RVA = "0x23FC4A0", Offset = "0x23FC4A0", VA = "0x23FC4A0")]
	private void StopProgressBarAnim()
	{
	}

	[Token(Token = "0x6011323")]
	[Address(RVA = "0x23FD76C", Offset = "0x23FD76C", VA = "0x23FD76C")]
	private IEnumerator ProgressBarAnimation()
	{
		return null;
	}

	[Token(Token = "0x6011324")]
	[Address(RVA = "0x23FD838", Offset = "0x23FD838", VA = "0x23FD838")]
	private void CheckMaxLevel(int newLevel, bool showGrownUpGo = true)
	{
	}

	[Token(Token = "0x6011325")]
	[Address(RVA = "0x23F6200", Offset = "0x23F6200", VA = "0x23F6200")]
	private void UpdateSelectBtn(proto.PetInfo info)
	{
	}

	[Token(Token = "0x6011326")]
	[Address(RVA = "0x23FC5F0", Offset = "0x23FC5F0", VA = "0x23FC5F0")]
	private void ShowActionList(List<PetActionData> dataList, bool selectByInfoIfNeed)
	{
	}

	[Token(Token = "0x6011327")]
	[Address(RVA = "0x23FCA5C", Offset = "0x23FCA5C", VA = "0x23FCA5C")]
	private void ShowSkinList(List<PetSkinData> dataList, bool selectByInfoIfNeed)
	{
	}

	[Token(Token = "0x6011328")]
	[Address(RVA = "0x23F5EBC", Offset = "0x23F5EBC", VA = "0x23F5EBC")]
	private void ShowCurrentSkillInfo(proto.PetInfo pet_info)
	{
	}

	[Token(Token = "0x6011329")]
	[Address(RVA = "0x23FD098", Offset = "0x23FD098", VA = "0x23FD098")]
	private void ShowSkillList(List<PetSkillInfoData> dataList)
	{
	}

	[Token(Token = "0x601132A")]
	[Address(RVA = "0x23FD9F4", Offset = "0x23FD9F4", VA = "0x23FD9F4", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x601132B")]
	[Address(RVA = "0x23FE0C0", Offset = "0x23FE0C0", VA = "0x23FE0C0", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x601132C")]
	[Address(RVA = "0x23FE124", Offset = "0x23FE124", VA = "0x23FE124", Slot = "31")]
	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	[Token(Token = "0x601132D")]
	[Address(RVA = "0x23FE318", Offset = "0x23FE318", VA = "0x23FE318")]
	private void CheckNeedSelectSkillGuide()
	{
	}

	[Token(Token = "0x601132E")]
	[Address(RVA = "0x23FBCB4", Offset = "0x23FBCB4", VA = "0x23FBCB4")]
	private void CheckPetFreeChangeName(proto.PetInfo PetInfo)
	{
	}

	[Token(Token = "0x601132F")]
	[Address(RVA = "0x23FE614", Offset = "0x23FE614", VA = "0x23FE614", Slot = "32")]
	public override void OnNavigationClosed()
	{
	}

	[Token(Token = "0x6011330")]
	[Address(RVA = "0x23FE69C", Offset = "0x23FE69C", VA = "0x23FE69C")]
	private void StopBGM(object[] data)
	{
	}

	[Token(Token = "0x6011331")]
	[Address(RVA = "0x23FE7D8", Offset = "0x23FE7D8", VA = "0x23FE7D8")]
	private void OnCarryStateClick()
	{
	}

	[Token(Token = "0x6011332")]
	[Address(RVA = "0x23F83DC", Offset = "0x23F83DC", VA = "0x23F83DC")]
	private void InitShareSelfProfile()
	{
	}

	[Token(Token = "0x6011333")]
	[Address(RVA = "0x23FE9EC", Offset = "0x23FE9EC", VA = "0x23FE9EC")]
	private void OnRenameClick()
	{
	}

	[Token(Token = "0x6011334")]
	[Address(RVA = "0x23FEB24", Offset = "0x23FEB24", VA = "0x23FEB24")]
	private void OnFeedPetLevelUpClick()
	{
	}

	[Token(Token = "0x6011335")]
	[Address(RVA = "0x23F692C", Offset = "0x23F692C", VA = "0x23F692C")]
	private void SetFeedButtonClickState(bool state)
	{
	}

	[Token(Token = "0x6011336")]
	[Address(RVA = "0x23FEF2C", Offset = "0x23FEF2C", VA = "0x23FEF2C")]
	private void OnBuyPetFoodClick()
	{
	}

	[Token(Token = "0x6011337")]
	[Address(RVA = "0x23FD588", Offset = "0x23FD588", VA = "0x23FD588")]
	private uint CalPetLevelUpFeedCount()
	{
		return default(uint);
	}

	[Token(Token = "0x6011338")]
	[Address(RVA = "0x23FF3E4", Offset = "0x23FF3E4", VA = "0x23FF3E4")]
	private bool IsPetMaxLevel()
	{
		return default(bool);
	}

	[Token(Token = "0x6011339")]
	[Address(RVA = "0x23FF4B4", Offset = "0x23FF4B4", VA = "0x23FF4B4", Slot = "64")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x601133A")]
	[Address(RVA = "0x23FF5AC", Offset = "0x23FF5AC", VA = "0x23FF5AC", Slot = "65")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x601133B")]
	[Address(RVA = "0x23FF628", Offset = "0x23FF628", VA = "0x23FF628")]
	private void OnShareBtnClick()
	{
	}

	[Token(Token = "0x601133C")]
	[Address(RVA = "0x23FF858", Offset = "0x23FF858", VA = "0x23FF858", Slot = "25")]
	public override void BeforeScreenshot()
	{
	}

	[Token(Token = "0x601133D")]
	[Address(RVA = "0x23FFAC8", Offset = "0x23FFAC8", VA = "0x23FFAC8", Slot = "26")]
	public override void AfterScreenshot()
	{
	}

	[Token(Token = "0x601133E")]
	[Address(RVA = "0x23FFD98", Offset = "0x23FFD98", VA = "0x23FFD98")]
	private void OnShowPetClick()
	{
	}

	[Token(Token = "0x601133F")]
	[Address(RVA = "0x23FFF98", Offset = "0x23FFF98", VA = "0x23FFF98", Slot = "38")]
	public override EFrontendBGMType GetBGMType()
	{
		return default(EFrontendBGMType);
	}

	[Token(Token = "0x6011340")]
	[Address(RVA = "0x23FFFF0", Offset = "0x23FFFF0", VA = "0x23FFFF0", Slot = "42")]
	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	[Token(Token = "0x6011341")]
	[Address(RVA = "0x2400060", Offset = "0x2400060", VA = "0x2400060", Slot = "43")]
	protected override FrontendPreviewType GetPreviewUIType()
	{
		return default(FrontendPreviewType);
	}

	[Token(Token = "0x6011342")]
	[Address(RVA = "0x24000B8", Offset = "0x24000B8", VA = "0x24000B8", Slot = "47")]
	protected override FrontEndPreviewComponent GetFrontEndPreviewComponent()
	{
		return null;
	}

	[Token(Token = "0x6011343")]
	[Address(RVA = "0x2400170", Offset = "0x2400170", VA = "0x2400170")]
	private bool _003COnDataChanged_003Em__0(proto.PetInfo temp)
	{
		return default(bool);
	}

	[Token(Token = "0x6011344")]
	[Address(RVA = "0x24001A8", Offset = "0x24001A8", VA = "0x24001A8")]
	private bool _003COnActionBtnClick_003Em__1(proto.PetInfo temp)
	{
		return default(bool);
	}

	[Token(Token = "0x6011345")]
	[Address(RVA = "0x24001E0", Offset = "0x24001E0", VA = "0x24001E0")]
	private bool _003COnSkinBtnClick_003Em__2(proto.PetInfo temp)
	{
		return default(bool);
	}

	[Token(Token = "0x6011346")]
	[Address(RVA = "0x2400218", Offset = "0x2400218", VA = "0x2400218")]
	private bool _003COnSkillBtnClick_003Em__3(proto.PetInfo temp)
	{
		return default(bool);
	}

	[Token(Token = "0x6011347")]
	[Address(RVA = "0x2400250", Offset = "0x2400250", VA = "0x2400250")]
	private bool _003CRefreshPriviewUIShow_003Em__4(proto.PetInfo temp)
	{
		return default(bool);
	}

	[Token(Token = "0x6011348")]
	[Address(RVA = "0x2400288", Offset = "0x2400288", VA = "0x2400288")]
	private bool _003CRefreshPetInfoPanel_003Em__5(proto.PetInfo temp)
	{
		return default(bool);
	}

	[Token(Token = "0x6011349")]
	[Address(RVA = "0x24002C0", Offset = "0x24002C0", VA = "0x24002C0")]
	private bool _003COnCarryStateClick_003Em__6(proto.PetInfo temp)
	{
		return default(bool);
	}

	[Token(Token = "0x601134A")]
	[Address(RVA = "0x24002F8", Offset = "0x24002F8", VA = "0x24002F8")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x601134B")]
	[Address(RVA = "0x2400300", Offset = "0x2400300", VA = "0x2400300")]
	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x601134C")]
	[Address(RVA = "0x2400308", Offset = "0x2400308", VA = "0x2400308")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x601134D")]
	[Address(RVA = "0x2400310", Offset = "0x2400310", VA = "0x2400310")]
	public new void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x601134E")]
	[Address(RVA = "0x2400318", Offset = "0x2400318", VA = "0x2400318")]
	public new void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	[Token(Token = "0x601134F")]
	[Address(RVA = "0x2400320", Offset = "0x2400320", VA = "0x2400320")]
	public new void _003C_003EiFixBaseProxy_OnNavigationClosed()
	{
	}

	[Token(Token = "0x6011350")]
	[Address(RVA = "0x2400328", Offset = "0x2400328", VA = "0x2400328")]
	public new void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	[Token(Token = "0x6011351")]
	[Address(RVA = "0x2400330", Offset = "0x2400330", VA = "0x2400330")]
	public new void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}

	[Token(Token = "0x6011352")]
	[Address(RVA = "0x2400338", Offset = "0x2400338", VA = "0x2400338")]
	public EFrontendBGMType _003C_003EiFixBaseProxy_GetBGMType()
	{
		return default(EFrontendBGMType);
	}

	[Token(Token = "0x6011353")]
	[Address(RVA = "0x2400340", Offset = "0x2400340", VA = "0x2400340")]
	public FrontEndPreviewComponent _003C_003EiFixBaseProxy_GetFrontEndPreviewComponent()
	{
		return null;
	}
}
