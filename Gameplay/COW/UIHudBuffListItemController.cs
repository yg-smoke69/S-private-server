using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20026FA")]
internal class UIHudBuffListItemController : UIBaseController
{
	[Token(Token = "0x400F09F")]
	[FieldOffset(Offset = "0x28")]
	private UIHudBuffListItemView m_View;

	[Token(Token = "0x400F0A0")]
	[FieldOffset(Offset = "0x2C")]
	public BountyPickupStatus BountyStatus;

	[Token(Token = "0x400F0A1")]
	[FieldOffset(Offset = "0x30")]
	private float m_TotalLife;

	[Token(Token = "0x400F0A2")]
	[FieldOffset(Offset = "0x34")]
	private float m_CurrentLife;

	[Token(Token = "0x400F0A3")]
	[FieldOffset(Offset = "0x38")]
	private KNAJBCCEAHI _003CBuffBevTypeID_003Ek__BackingField;

	[Token(Token = "0x170011B2")]
	public KNAJBCCEAHI BuffBevTypeID
	{
		[Token(Token = "0x600EC95")]
		[Address(RVA = "0x1E1935C", Offset = "0x1E1935C", VA = "0x1E1935C")]
		get
		{
			return default(KNAJBCCEAHI);
		}
		[Token(Token = "0x600EC96")]
		[Address(RVA = "0x1E197DC", Offset = "0x1E197DC", VA = "0x1E197DC")]
		set
		{
		}
	}

	[Token(Token = "0x600EC94")]
	[Address(RVA = "0x1E19750", Offset = "0x1E19750", VA = "0x1E19750")]
	public UIHudBuffListItemController()
	{
	}

	[Token(Token = "0x600EC97")]
	[Address(RVA = "0x1E197E4", Offset = "0x1E197E4", VA = "0x1E197E4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600EC98")]
	[Address(RVA = "0x1E19888", Offset = "0x1E19888", VA = "0x1E19888", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600EC99")]
	[Address(RVA = "0x1E19530", Offset = "0x1E19530", VA = "0x1E19530")]
	public void SetUIData(CBIKNJDAGLO bevData)
	{
	}

	[Token(Token = "0x600EC9A")]
	[Address(RVA = "0x1E19944", Offset = "0x1E19944", VA = "0x1E19944")]
	protected void Update()
	{
	}

	[Token(Token = "0x600EC9B")]
	[Address(RVA = "0x1E19364", Offset = "0x1E19364", VA = "0x1E19364")]
	public void UpdateLifeTime(float life)
	{
	}

	[Token(Token = "0x600EC9C")]
	[Address(RVA = "0x1E19A54", Offset = "0x1E19A54", VA = "0x1E19A54")]
	private void UpdateCDProgress()
	{
	}

	[Token(Token = "0x600EC9D")]
	[Address(RVA = "0x1E19BC4", Offset = "0x1E19BC4", VA = "0x1E19BC4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
