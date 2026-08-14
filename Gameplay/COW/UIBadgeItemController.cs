using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20024F2")]
public class UIBadgeItemController : UIBaseController
{
	[Token(Token = "0x400E50A")]
	[FieldOffset(Offset = "0x28")]
	private UIBadgeItemView m_View;

	[Token(Token = "0x400E50B")]
	[FieldOffset(Offset = "0x2C")]
	public BadgeItemState State;

	[Token(Token = "0x400E50C")]
	[FieldOffset(Offset = "0x30")]
	private uint m_BadgeItemId;

	[Token(Token = "0x400E50D")]
	[FieldOffset(Offset = "0x34")]
	private UIModelClan m_ModelClan;

	[Token(Token = "0x600D514")]
	[Address(RVA = "0x1403320", Offset = "0x1403320", VA = "0x1403320")]
	public UIBadgeItemController()
	{
	}

	[Token(Token = "0x600D515")]
	[Address(RVA = "0x14033A4", Offset = "0x14033A4", VA = "0x14033A4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D516")]
	[Address(RVA = "0x1403448", Offset = "0x1403448", VA = "0x1403448", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D517")]
	[Address(RVA = "0x14037B4", Offset = "0x14037B4", VA = "0x14037B4")]
	public void SetClanBadgeItemId(uint id)
	{
	}

	[Token(Token = "0x600D518")]
	[Address(RVA = "0x1403814", Offset = "0x1403814", VA = "0x1403814")]
	public void SetBadgeLockState()
	{
	}

	[Token(Token = "0x600D519")]
	[Address(RVA = "0x14038A4", Offset = "0x14038A4", VA = "0x14038A4")]
	public void SetSprite(string ResName)
	{
	}

	[Token(Token = "0x600D51A")]
	[Address(RVA = "0x14039B8", Offset = "0x14039B8", VA = "0x14039B8")]
	public void SetExpireTime(ulong expireTime)
	{
	}

	[Token(Token = "0x600D51B")]
	[Address(RVA = "0x1403BE8", Offset = "0x1403BE8", VA = "0x1403BE8")]
	private void OnSelectBadge()
	{
	}

	[Token(Token = "0x600D51C")]
	[Address(RVA = "0x1403D84", Offset = "0x1403D84", VA = "0x1403D84")]
	public void SetBadgeSelectState(bool HasSelect)
	{
	}

	[Token(Token = "0x600D51D")]
	[Address(RVA = "0x1403624", Offset = "0x1403624", VA = "0x1403624")]
	public void SetBadgeNormalState()
	{
	}

	[Token(Token = "0x600D51E")]
	[Address(RVA = "0x1403E1C", Offset = "0x1403E1C", VA = "0x1403E1C")]
	public void SetBadgeUsingState(bool HasUsing)
	{
	}

	[Token(Token = "0x600D51F")]
	[Address(RVA = "0x1403EB4", Offset = "0x1403EB4", VA = "0x1403EB4")]
	public void SetBadgeSpecialEffect()
	{
	}

	[Token(Token = "0x600D520")]
	[Address(RVA = "0x1403F44", Offset = "0x1403F44", VA = "0x1403F44")]
	private void _003CSetExpireTime_003Em__0()
	{
	}

	[Token(Token = "0x600D521")]
	[Address(RVA = "0x140421C", Offset = "0x140421C", VA = "0x140421C")]
	private bool _003CSetExpireTime_003Em__1(ClanBadgeItemInfo item)
	{
		return default(bool);
	}

	[Token(Token = "0x600D522")]
	[Address(RVA = "0x1404254", Offset = "0x1404254", VA = "0x1404254")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
