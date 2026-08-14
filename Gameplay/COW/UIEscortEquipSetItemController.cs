using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200260B")]
public class UIEscortEquipSetItemController : UIEquipSetItemController
{
	[Token(Token = "0x200260C")]
	private sealed class _003CPlayForbidEffect_003Ec__AnonStorey0
	{
		[Token(Token = "0x400EAE8")]
		[FieldOffset(Offset = "0x8")]
		internal string name;

		[Token(Token = "0x400EAE9")]
		[FieldOffset(Offset = "0xC")]
		internal UIEscortEquipSetItemController _0024this;

		[Token(Token = "0x600E108")]
		[Address(RVA = "0x19DB7F4", Offset = "0x19DB7F4", VA = "0x19DB7F4")]
		public _003CPlayForbidEffect_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600E109")]
		[Address(RVA = "0x19DB8B8", Offset = "0x19DB8B8", VA = "0x19DB8B8")]
		internal void _003C_003Em__0()
		{
		}
	}

	[Token(Token = "0x400EAE7")]
	[FieldOffset(Offset = "0x3C")]
	private UIEScortEquipSetItemView m_View;

	[Token(Token = "0x600E0FA")]
	[Address(RVA = "0x19DA778", Offset = "0x19DA778", VA = "0x19DA778")]
	public UIEscortEquipSetItemController()
	{
	}

	[Token(Token = "0x600E0FB")]
	[Address(RVA = "0x19DA77C", Offset = "0x19DA77C", VA = "0x19DA77C")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E0FC")]
	[Address(RVA = "0x19DA824", Offset = "0x19DA824", VA = "0x19DA824", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E0FD")]
	[Address(RVA = "0x19DAA20", Offset = "0x19DAA20", VA = "0x19DAA20")]
	public new void SetUIData(int index, LinkEquipSetData data)
	{
	}

	[Token(Token = "0x600E0FE")]
	[Address(RVA = "0x19DAD40", Offset = "0x19DAD40", VA = "0x19DAD40")]
	private void SetEquips(EquipIdCountDataList data, GameObject widget, UILabel nameLabel, UISprite icon, bool bigIcon = false)
	{
	}

	[Token(Token = "0x600E0FF")]
	[Address(RVA = "0x19DADF8", Offset = "0x19DADF8", VA = "0x19DADF8")]
	private LGCOKIBHIJL SetEquipWidget(EquipIdCountDataList data, GameObject widget)
	{
		return null;
	}

	[Token(Token = "0x600E100")]
	[Address(RVA = "0x19DAFE8", Offset = "0x19DAFE8", VA = "0x19DAFE8")]
	private void SetEquips(LGCOKIBHIJL itemData, UILabel nameLabel, UISprite icon, bool bigIcon)
	{
	}

	[Token(Token = "0x600E101")]
	[Address(RVA = "0x19DB1BC", Offset = "0x19DB1BC", VA = "0x19DB1BC")]
	private void SetArmor(EquipIdCountDataList data, GameObject widget, UISprite icon)
	{
	}

	[Token(Token = "0x600E102")]
	[Address(RVA = "0x19DA988", Offset = "0x19DA988", VA = "0x19DA988")]
	public new void Highlight(bool highlight)
	{
	}

	[Token(Token = "0x600E103")]
	[Address(RVA = "0x19DB3B8", Offset = "0x19DB3B8", VA = "0x19DB3B8")]
	public new void SetForbidChoose(bool choosed, string name = "")
	{
	}

	[Token(Token = "0x600E104")]
	[Address(RVA = "0x19DB75C", Offset = "0x19DB75C", VA = "0x19DB75C")]
	public new void SetEscortModeInfo(string info)
	{
	}

	[Token(Token = "0x600E105")]
	[Address(RVA = "0x19DB540", Offset = "0x19DB540", VA = "0x19DB540")]
	private void PlayForbidEffect(GameObject go, string name)
	{
	}

	[Token(Token = "0x600E106")]
	[Address(RVA = "0x19DB7FC", Offset = "0x19DB7FC", VA = "0x19DB7FC")]
	private void OnClick()
	{
	}

	[Token(Token = "0x600E107")]
	[Address(RVA = "0x19DB8B4", Offset = "0x19DB8B4", VA = "0x19DB8B4")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
