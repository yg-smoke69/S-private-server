using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200334D")]
internal class UIHudChokePointBuffDurationController : UIBaseController
{
	[Token(Token = "0x40138B0")]
	[FieldOffset(Offset = "0x28")]
	private UIHudChokePointBuffDurationView m_View;

	[Token(Token = "0x40138B1")]
	[FieldOffset(Offset = "0x2C")]
	private float m_BuffDurationTime;

	[Token(Token = "0x40138B2")]
	[FieldOffset(Offset = "0x30")]
	private float m_BuffEndTime;

	[Token(Token = "0x40138B3")]
	[FieldOffset(Offset = "0x34")]
	private float m_Duration;

	[Token(Token = "0x6015CDE")]
	[Address(RVA = "0x135C6F8", Offset = "0x135C6F8", VA = "0x135C6F8")]
	public UIHudChokePointBuffDurationController()
	{
	}

	[Token(Token = "0x6015CDF")]
	[Address(RVA = "0x135C77C", Offset = "0x135C77C", VA = "0x135C77C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6015CE0")]
	[Address(RVA = "0x135C824", Offset = "0x135C824", VA = "0x135C824", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6015CE1")]
	[Address(RVA = "0x135C8E0", Offset = "0x135C8E0", VA = "0x135C8E0")]
	public void SetDurationEndTime(float lifeTime, float duration)
	{
	}

	[Token(Token = "0x6015CE2")]
	[Address(RVA = "0x135C9FC", Offset = "0x135C9FC", VA = "0x135C9FC")]
	private void Update()
	{
	}

	[Token(Token = "0x6015CE3")]
	[Address(RVA = "0x135CAFC", Offset = "0x135CAFC", VA = "0x135CAFC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
