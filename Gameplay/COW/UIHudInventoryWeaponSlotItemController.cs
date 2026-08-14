using System.Text;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200278D")]
internal class UIHudInventoryWeaponSlotItemController : UIInventoryItemControllerBase
{
	[Token(Token = "0x400F439")]
	[FieldOffset(Offset = "0x30")]
	protected UIHudInventoryWeaponSlotItemView m_View;

	[Token(Token = "0x400F43A")]
	[FieldOffset(Offset = "0x34")]
	private GameObject m_EmptyBG;

	[Token(Token = "0x400F43B")]
	[FieldOffset(Offset = "0x38")]
	private UIHudInventoryAttachmentSlotItemController[] m_Attachments;

	[Token(Token = "0x400F43C")]
	[FieldOffset(Offset = "0x3C")]
	private StringBuilder m_Sb;

	[Token(Token = "0x400F43D")]
	[FieldOffset(Offset = "0x40")]
	private bool m_EnergyWeaponEventsRegisterd;

	[Token(Token = "0x400F43E")]
	[FieldOffset(Offset = "0x44")]
	private uint m_ShowingSpriteWeaponId;

	[Token(Token = "0x400F43F")]
	[FieldOffset(Offset = "0x48")]
	private bool canUpgrade;

	[Token(Token = "0x400F440")]
	[FieldOffset(Offset = "0x4C")]
	private GameObject m_replaceEffect;

	[Token(Token = "0x600F36B")]
	[Address(RVA = "0x20A05A0", Offset = "0x20A05A0", VA = "0x20A05A0")]
	public UIHudInventoryWeaponSlotItemController()
	{
	}

	[Token(Token = "0x600F36C")]
	[Address(RVA = "0x20A0614", Offset = "0x20A0614", VA = "0x20A0614")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600F36D")]
	[Address(RVA = "0x20A06B8", Offset = "0x20A06B8", VA = "0x20A06B8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600F36E")]
	[Address(RVA = "0x20A2A54", Offset = "0x20A2A54", VA = "0x20A2A54", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600F36F")]
	[Address(RVA = "0x20A2C1C", Offset = "0x20A2C1C", VA = "0x20A2C1C")]
	public UIInventoryItemDragDropContainer GetDragContatiner()
	{
		return null;
	}

	[Token(Token = "0x600F370")]
	[Address(RVA = "0x20A2C8C", Offset = "0x20A2C8C", VA = "0x20A2C8C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600F371")]
	[Address(RVA = "0x20A2F9C", Offset = "0x20A2F9C", VA = "0x20A2F9C")]
	private void RegisterEnergyWeaponEvents()
	{
	}

	[Token(Token = "0x600F372")]
	[Address(RVA = "0x20A2E60", Offset = "0x20A2E60", VA = "0x20A2E60")]
	private void UnRegisterEnergyWeaponEvents()
	{
	}

	[Token(Token = "0x600F373")]
	[Address(RVA = "0x20A30D8", Offset = "0x20A30D8", VA = "0x20A30D8")]
	private void OnEnergyWeaponEnergyChange(object[] ps)
	{
	}

	[Token(Token = "0x600F374")]
	[Address(RVA = "0x20A3140", Offset = "0x20A3140", VA = "0x20A3140")]
	public void RefreshWeaponAmmo()
	{
	}

	[Token(Token = "0x600F375")]
	[Address(RVA = "0x20A3518", Offset = "0x20A3518", VA = "0x20A3518")]
	public void RefreshAttachmentState()
	{
	}

	[Token(Token = "0x600F376")]
	[Address(RVA = "0x20A3F50", Offset = "0x20A3F50", VA = "0x20A3F50")]
	public void SetDrapDropType(EInventoryDragDropContainerType type, GameObject emptyBG)
	{
	}

	[Token(Token = "0x600F377")]
	[Address(RVA = "0x20A3FF8", Offset = "0x20A3FF8", VA = "0x20A3FF8")]
	public void RefreshWeaponSprite()
	{
	}

	[Token(Token = "0x600F378")]
	[Address(RVA = "0x20A46D4", Offset = "0x20A46D4", VA = "0x20A46D4")]
	private void OnApplicationFocus(bool hasFocus)
	{
	}

	[Token(Token = "0x600F379")]
	[Address(RVA = "0x20A4934", Offset = "0x20A4934", VA = "0x20A4934")]
	private void OnInventoryOpen(object[] data)
	{
	}

	[Token(Token = "0x600F37A")]
	[Address(RVA = "0x20A15C0", Offset = "0x20A15C0", VA = "0x20A15C0")]
	public void SetUIData(UIItem item)
	{
	}

	[Token(Token = "0x600F37B")]
	[Address(RVA = "0x20A4B30", Offset = "0x20A4B30", VA = "0x20A4B30", Slot = "35")]
	protected override bool HandleReleaseEvent(UIInventoryItemDragDropContainer container)
	{
		return default(bool);
	}

	[Token(Token = "0x600F37C")]
	[Address(RVA = "0x20A5034", Offset = "0x20A5034", VA = "0x20A5034", Slot = "33")]
	public override void OnDrapStart()
	{
	}

	[Token(Token = "0x600F37D")]
	[Address(RVA = "0x20A5140", Offset = "0x20A5140", VA = "0x20A5140", Slot = "34")]
	public override bool OnDrapRelease(UIInventoryItemDragDropContainer container)
	{
		return default(bool);
	}

	[Token(Token = "0x600F37E")]
	[Address(RVA = "0x20A52C8", Offset = "0x20A52C8", VA = "0x20A52C8", Slot = "37")]
	public override UIToggle GetToggle()
	{
		return null;
	}

	[Token(Token = "0x600F37F")]
	[Address(RVA = "0x20A5338", Offset = "0x20A5338", VA = "0x20A5338", Slot = "38")]
	public override GameObject GetHighlightGO()
	{
		return null;
	}

	[Token(Token = "0x600F380")]
	[Address(RVA = "0x20A53A8", Offset = "0x20A53A8", VA = "0x20A53A8", Slot = "39")]
	public override GameObject GetDragGO()
	{
		return null;
	}

	[Token(Token = "0x600F381")]
	[Address(RVA = "0x20A5418", Offset = "0x20A5418", VA = "0x20A5418", Slot = "40")]
	public override GameObject GetNonDragGO()
	{
		return null;
	}

	[Token(Token = "0x600F382")]
	[Address(RVA = "0x20A5488", Offset = "0x20A5488", VA = "0x20A5488", Slot = "41")]
	public override GameObject GetDragRedGo()
	{
		return null;
	}

	[Token(Token = "0x600F383")]
	[Address(RVA = "0x20A54F8", Offset = "0x20A54F8", VA = "0x20A54F8")]
	public void UpdateReplaceState(AAHMJHHPECM replacer)
	{
	}

	[Token(Token = "0x600F384")]
	[Address(RVA = "0x20A59A0", Offset = "0x20A59A0", VA = "0x20A59A0")]
	public void RefreshGoldUpgradeStatus()
	{
	}

	[Token(Token = "0x600F385")]
	[Address(RVA = "0x20A5B3C", Offset = "0x20A5B3C", VA = "0x20A5B3C")]
	public void UpgradeWeapon()
	{
	}

	[Token(Token = "0x600F386")]
	[Address(RVA = "0x20A5E30", Offset = "0x20A5E30", VA = "0x20A5E30")]
	public void RefreshUpgradeEffect(bool isShow)
	{
	}

	[Token(Token = "0x600F387")]
	[Address(RVA = "0x20A2B1C", Offset = "0x20A2B1C", VA = "0x20A2B1C")]
	private void RefreshUpgradeEffect()
	{
	}

	[Token(Token = "0x600F388")]
	[Address(RVA = "0x20A5E8C", Offset = "0x20A5E8C", VA = "0x20A5E8C")]
	private void PlayerRealUpgradeEffect(object[] param)
	{
	}

	[Token(Token = "0x600F389")]
	[Address(RVA = "0x20A605C", Offset = "0x20A605C", VA = "0x20A605C")]
	private void _003COnUIInit_003Em__0()
	{
	}

	[Token(Token = "0x600F38A")]
	[Address(RVA = "0x20A61B4", Offset = "0x20A61B4", VA = "0x20A61B4")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600F38B")]
	[Address(RVA = "0x20A61BC", Offset = "0x20A61BC", VA = "0x20A61BC")]
	public void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600F38C")]
	[Address(RVA = "0x20A61C4", Offset = "0x20A61C4", VA = "0x20A61C4")]
	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600F38D")]
	[Address(RVA = "0x20A61CC", Offset = "0x20A61CC", VA = "0x20A61CC")]
	public bool _003C_003EiFixBaseProxy_HandleReleaseEvent(UIInventoryItemDragDropContainer P0)
	{
		return default(bool);
	}

	[Token(Token = "0x600F38E")]
	[Address(RVA = "0x20A61D4", Offset = "0x20A61D4", VA = "0x20A61D4")]
	public void _003C_003EiFixBaseProxy_OnDrapStart()
	{
	}

	[Token(Token = "0x600F38F")]
	[Address(RVA = "0x20A61DC", Offset = "0x20A61DC", VA = "0x20A61DC")]
	public bool _003C_003EiFixBaseProxy_OnDrapRelease(UIInventoryItemDragDropContainer P0)
	{
		return default(bool);
	}
}
