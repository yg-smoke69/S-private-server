using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002991")]
public class UIManualMapSupplyItemController : UIBaseController, _Attribute
{
	[Token(Token = "0x400FFE6")]
	[FieldOffset(Offset = "0x28")]
	private UIManualMapSupplyItemView m_View;

	[Token(Token = "0x400FFE7")]
	[FieldOffset(Offset = "0x2C")]
	private ManualInMapData m_Data;

	[Token(Token = "0x400FFE8")]
	[FieldOffset(Offset = "0x30")]
	private bool _003CIsUnlock_003Ek__BackingField;

	[Token(Token = "0x400FFE9")]
	[FieldOffset(Offset = "0x31")]
	private bool _003CIsSelected_003Ek__BackingField;

	[Token(Token = "0x17001262")]
	public bool IsUnlock
	{
		[Token(Token = "0x6010B08")]
		[Address(RVA = "0x2C40410", Offset = "0x2C40410", VA = "0x2C40410")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6010B09")]
		[Address(RVA = "0x2C3FC0C", Offset = "0x2C3FC0C", VA = "0x2C3FC0C")]
		set
		{
		}
	}

	[Token(Token = "0x17001263")]
	public bool IsSelected
	{
		[Token(Token = "0x6010B0A")]
		[Address(RVA = "0x2C40418", Offset = "0x2C40418", VA = "0x2C40418")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6010B0B")]
		[Address(RVA = "0x2C3F568", Offset = "0x2C3F568", VA = "0x2C3F568")]
		set
		{
		}
	}

	[Token(Token = "0x6010B07")]
	[Address(RVA = "0x2C4038C", Offset = "0x2C4038C", VA = "0x2C4038C")]
	public UIManualMapSupplyItemController()
	{
	}

	[Token(Token = "0x6010B0C")]
	[Address(RVA = "0x2C40420", Offset = "0x2C40420", VA = "0x2C40420")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010B0D")]
	[Address(RVA = "0x2C404C4", Offset = "0x2C404C4", VA = "0x2C404C4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010B0E")]
	[Address(RVA = "0x2C40688", Offset = "0x2C40688", VA = "0x2C40688", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x6010B0F")]
	[Address(RVA = "0x2C406EC", Offset = "0x2C406EC", VA = "0x2C406EC", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6010B10")]
	[Address(RVA = "0x2C3FBAC", Offset = "0x2C3FBAC", VA = "0x2C3FBAC")]
	public void SetData(ManualInMapData data)
	{
	}

	[Token(Token = "0x6010B11")]
	[Address(RVA = "0x2C3EFE8", Offset = "0x2C3EFE8", VA = "0x2C3EFE8")]
	public void RefreshView()
	{
	}

	[Token(Token = "0x6010B12")]
	[Address(RVA = "0x2C3FC14", Offset = "0x2C3FC14", VA = "0x2C3FC14")]
	public void OnButtonClick()
	{
	}

	[Token(Token = "0x6010B13")]
	[Address(RVA = "0x2C407F4", Offset = "0x2C407F4", VA = "0x2C407F4", Slot = "31")]
	public void OnTipsDataChange(ETipsType type, int num)
	{
	}

	[Token(Token = "0x6010B14")]
	[Address(RVA = "0x2C4099C", Offset = "0x2C4099C", VA = "0x2C4099C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6010B15")]
	[Address(RVA = "0x2C409A4", Offset = "0x2C409A4", VA = "0x2C409A4")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x6010B16")]
	[Address(RVA = "0x2C409AC", Offset = "0x2C409AC", VA = "0x2C409AC")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
