using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002CBC")]
public abstract class UIFrontEndPreviewItemDescBaseController : UIFrontEndPreviewUIComponentTemplateBaseController<UIFrontEndPreviewItemDescBaseView>
{
	[Token(Token = "0x2002CBD")]
	private sealed class _003CRefreshItemDesc_003Ec__AnonStorey0
	{
		[Token(Token = "0x4011130")]
		[FieldOffset(Offset = "0x8")]
		internal uint petId;

		[Token(Token = "0x6012BC1")]
		[Address(RVA = "0xE8B6A4", Offset = "0xE8B6A4", VA = "0xE8B6A4")]
		public _003CRefreshItemDesc_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6012BC2")]
		[Address(RVA = "0xE8E6D8", Offset = "0xE8E6D8", VA = "0xE8E6D8")]
		internal bool _003C_003Em__0(PetInfo x)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4011127")]
	[FieldOffset(Offset = "0x38")]
	private List<GameObject> m_IconObjects;

	[Token(Token = "0x4011128")]
	[FieldOffset(Offset = "0x3C")]
	private AvatarSkillData m_AvatarSkillData;

	[Token(Token = "0x4011129")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<int, string> m_GenderSpr;

	[Token(Token = "0x401112A")]
	[FieldOffset(Offset = "0x40")]
	private readonly Color colorWhite;

	[Token(Token = "0x401112B")]
	[FieldOffset(Offset = "0x50")]
	private readonly Color colorGreen;

	[Token(Token = "0x401112C")]
	[FieldOffset(Offset = "0x60")]
	private readonly Color colorRed;

	[Token(Token = "0x401112D")]
	[FieldOffset(Offset = "0x70")]
	private readonly Color colorBlue;

	[Token(Token = "0x401112E")]
	[FieldOffset(Offset = "0x80")]
	private readonly Color colorPurple;

	[Token(Token = "0x401112F")]
	[FieldOffset(Offset = "0x90")]
	private readonly Color colorOrange;

	[Token(Token = "0x6012B92")]
	[Address(RVA = "0xE85A8C", Offset = "0xE85A8C", VA = "0xE85A8C")]
	protected UIFrontEndPreviewItemDescBaseController()
	{
	}

	[Token(Token = "0x6012B93")]
	[Address(RVA = "0xE85CB8", Offset = "0xE85CB8", VA = "0xE85CB8", Slot = "32")]
	protected override void InitView()
	{
	}

	[Token(Token = "0x6012B94")]
	[Address(RVA = "0xE865E4", Offset = "0xE865E4", VA = "0xE865E4")]
	private void DescLabelCallBack(int lines)
	{
	}

	[Token(Token = "0x6012B95")]
	[Address(RVA = "0xE86684", Offset = "0xE86684", VA = "0xE86684", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x6012B96")]
	[Address(RVA = "0xE8671C", Offset = "0xE8671C", VA = "0xE8671C", Slot = "36")]
	public virtual Vector3 GetItemDescLocalPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6012B97")]
	[Address(RVA = "0xE867D4", Offset = "0xE867D4", VA = "0xE867D4", Slot = "37")]
	public virtual void SetItemDescLocalPosition(Vector3 pos)
	{
	}

	[Token(Token = "0x6012B98")]
	[Address(RVA = "0xE86848", Offset = "0xE86848", VA = "0xE86848", Slot = "38")]
	public virtual void SetIpTag(ResourceID resourceID)
	{
	}

	[Token(Token = "0x6012B99")]
	[Address(RVA = "0xE869A8", Offset = "0xE869A8", VA = "0xE869A8", Slot = "39")]
	public virtual void SetSpecialData(string name, string desc, bool flag)
	{
	}

	[Token(Token = "0x6012B9A")]
	[Address(RVA = "0xE86EAC", Offset = "0xE86EAC", VA = "0xE86EAC", Slot = "40")]
	public virtual void OnSetOriginal()
	{
	}

	[Token(Token = "0x6012B9B")]
	[Address(RVA = "0xE86F14", Offset = "0xE86F14", VA = "0xE86F14", Slot = "41")]
	public virtual void OnCloseUIExceptMagn()
	{
	}

	[Token(Token = "0x6012B9C")]
	[Address(RVA = "0xE86F7C", Offset = "0xE86F7C", VA = "0xE86F7C", Slot = "42")]
	public virtual void OnCloseAllUI()
	{
	}

	[Token(Token = "0x6012B9D")]
	[Address(RVA = "0xE86FE4", Offset = "0xE86FE4", VA = "0xE86FE4", Slot = "43")]
	public virtual void OnCloseUIInGacha()
	{
	}

	[Token(Token = "0x6012B9E")]
	[Address(RVA = "0xE8704C", Offset = "0xE8704C", VA = "0xE8704C", Slot = "44")]
	public virtual void SetNewQuaityIcon(uint id)
	{
	}

	[Token(Token = "0x6012B9F")]
	[Address(RVA = "0xE8776C", Offset = "0xE8776C", VA = "0xE8776C")]
	public void UpdateDescLabelYPos(int offset)
	{
	}

	[Token(Token = "0x6012BA0")]
	[Address(RVA = "0xE878BC", Offset = "0xE878BC", VA = "0xE878BC", Slot = "45")]
	protected virtual void SetItemDescBg()
	{
	}

	[Token(Token = "0x6012BA1")]
	[Address(RVA = "0xE87E38", Offset = "0xE87E38", VA = "0xE87E38", Slot = "46")]
	protected virtual void OnItemDescBgChanged()
	{
	}

	[Token(Token = "0x6012BA2")]
	[Address(RVA = "0xE87E8C", Offset = "0xE87E8C", VA = "0xE87E8C", Slot = "47")]
	public virtual void SetNewQuaitySpIcon(EInventory.AwardType type)
	{
	}

	[Token(Token = "0x6012BA3")]
	[Address(RVA = "0xE8803C", Offset = "0xE8803C", VA = "0xE8803C", Slot = "48")]
	public virtual void WeaponSkinUpgradeInfoIconClick(string info, List<ResourceID> spritesResId)
	{
	}

	[Token(Token = "0x6012BA4")]
	[Address(RVA = "0xE881F8", Offset = "0xE881F8", VA = "0xE881F8", Slot = "49")]
	public virtual void SetItemDescYPos(float nameposY, float descposY)
	{
	}

	[Token(Token = "0x6012BA5")]
	[Address(RVA = "0xE884EC", Offset = "0xE884EC", VA = "0xE884EC", Slot = "50")]
	public virtual Vector2 GetItemNameWorldPos()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector2);
	}

	[Token(Token = "0x6012BA6")]
	[Address(RVA = "0xE886D8", Offset = "0xE886D8", VA = "0xE886D8", Slot = "51")]
	public virtual Vector2 GetItemDescWorldPos()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector2);
	}

	[Token(Token = "0x6012BA7")]
	[Address(RVA = "0xE888C4", Offset = "0xE888C4", VA = "0xE888C4", Slot = "52")]
	public virtual void OnDisVisbleIconTableInfo()
	{
	}

	[Token(Token = "0x6012BA8")]
	[Address(RVA = "0xE88B24", Offset = "0xE88B24", VA = "0xE88B24", Slot = "53")]
	public virtual bool CheckIDInvaild(uint itemid)
	{
		return default(bool);
	}

	[Token(Token = "0x6012BA9")]
	[Address(RVA = "0xE88BC4", Offset = "0xE88BC4", VA = "0xE88BC4", Slot = "54")]
	public virtual void RefreshItemDesc(uint itemid, UIGrid iconGrid)
	{
	}

	[Token(Token = "0x6012BAA")]
	[Address(RVA = "0xE8B6AC", Offset = "0xE8B6AC", VA = "0xE8B6AC", Slot = "55")]
	public virtual void ShowEffectClothIcon(UIGrid iconGrid)
	{
	}

	[Token(Token = "0x6012BAB")]
	[Address(RVA = "0xE8B9D8", Offset = "0xE8B9D8", VA = "0xE8B9D8", Slot = "56")]
	public virtual void SetItemDesc(string name, string description)
	{
	}

	[Token(Token = "0x6012BAC")]
	[Address(RVA = "0xE8BE38", Offset = "0xE8BE38", VA = "0xE8BE38", Slot = "57")]
	public virtual void OnRefreshWeaponPropertyScore(bool showIcon, bool weaponSkinUpgradeInfoIcon, bool notificationIcon)
	{
	}

	[Token(Token = "0x6012BAD")]
	[Address(RVA = "0xE8BF5C", Offset = "0xE8BF5C", VA = "0xE8BF5C", Slot = "58")]
	public virtual void OnRefreshEmotePrivilegeIcon(bool show)
	{
	}

	[Token(Token = "0x6012BAE")]
	[Address(RVA = "0xE8C050", Offset = "0xE8C050", VA = "0xE8C050", Slot = "59")]
	public virtual void SetSkillVisble(bool isVisble)
	{
	}

	[Token(Token = "0x6012BAF")]
	[Address(RVA = "0xE8C14C", Offset = "0xE8C14C", VA = "0xE8C14C", Slot = "60")]
	public virtual void SetAlignmentVisble(bool show)
	{
	}

	[Token(Token = "0x6012BB0")]
	[Address(RVA = "0xE8C1A8", Offset = "0xE8C1A8", VA = "0xE8C1A8", Slot = "61")]
	public virtual void OnSetNotificationBtnVisble(bool need_show, bool needCombine = false)
	{
	}

	[Token(Token = "0x6012BB1")]
	[Address(RVA = "0xE8C29C", Offset = "0xE8C29C", VA = "0xE8C29C", Slot = "62")]
	public virtual void SetShowIconVisble(bool need_show)
	{
	}

	[Token(Token = "0x6012BB2")]
	[Address(RVA = "0xE8C370", Offset = "0xE8C370", VA = "0xE8C370", Slot = "63")]
	public virtual void SetWeaponSkinUpgradeInfoIconVisble(bool need_show)
	{
	}

	[Token(Token = "0x6012BB3")]
	[Address(RVA = "0xE8C444", Offset = "0xE8C444", VA = "0xE8C444", Slot = "64")]
	public virtual void OnShowAvatarSkill(AvatarSkillData skilldata)
	{
	}

	[Token(Token = "0x6012BB4")]
	[Address(RVA = "0xE8C694", Offset = "0xE8C694", VA = "0xE8C694", Slot = "65")]
	public virtual void ShowAvatarAlignment(uint avatarID)
	{
	}

	[Token(Token = "0x6012BB5")]
	[Address(RVA = "0xE8C6F0", Offset = "0xE8C6F0", VA = "0xE8C6F0", Slot = "66")]
	public virtual void OnShowPetSkill(CSSharedItemData skilldata)
	{
	}

	[Token(Token = "0x6012BB6")]
	[Address(RVA = "0xE8C8F0", Offset = "0xE8C8F0", VA = "0xE8C8F0", Slot = "67")]
	protected virtual void OnForgeAwardBtnClick()
	{
	}

	[Token(Token = "0x6012BB7")]
	[Address(RVA = "0xE8CB10", Offset = "0xE8CB10", VA = "0xE8CB10", Slot = "68")]
	public virtual void ShowIPTag(uint id)
	{
	}

	[Token(Token = "0x6012BB8")]
	[Address(RVA = "0xE8CDA0", Offset = "0xE8CDA0", VA = "0xE8CDA0", Slot = "69")]
	protected virtual void OnShowIconBtnClick()
	{
	}

	[Token(Token = "0x6012BB9")]
	[Address(RVA = "0xE8CFFC", Offset = "0xE8CFFC", VA = "0xE8CFFC", Slot = "70")]
	protected virtual void OnNotificationIconBtnClick()
	{
	}

	[Token(Token = "0x6012BBA")]
	[Address(RVA = "0xE8D258", Offset = "0xE8D258", VA = "0xE8D258")]
	private void OnWeaponSkinUpgradeInfoIconClick()
	{
	}

	[Token(Token = "0x6012BBB")]
	[Address(RVA = "0xE8DD60", Offset = "0xE8DD60", VA = "0xE8DD60")]
	private void OnCollectionEmotePrivilegeIconClick()
	{
	}

	[Token(Token = "0x6012BBC")]
	[Address(RVA = "0xE8643C", Offset = "0xE8643C", VA = "0xE8643C")]
	private void ResetTable()
	{
	}

	[Token(Token = "0x6012BBD")]
	[Address(RVA = "0xE8E044", Offset = "0xE8E044", VA = "0xE8E044")]
	private void OnBtnSkillClick()
	{
	}

	[Token(Token = "0x6012BBF")]
	[Address(RVA = "0xE8E6CC", Offset = "0xE8E6CC", VA = "0xE8E6CC")]
	public void _003C_003EiFixBaseProxy_InitView()
	{
	}

	[Token(Token = "0x6012BC0")]
	[Address(RVA = "0xE8E6D0", Offset = "0xE8E6D0", VA = "0xE8E6D0")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
