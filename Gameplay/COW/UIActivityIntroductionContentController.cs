using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001F64")]
public class UIActivityIntroductionContentController : UIActivityContentController
{
	[Token(Token = "0x2001F65")]
	public class Data
	{
		[Token(Token = "0x400C531")]
		[FieldOffset(Offset = "0x8")]
		public uint groupId;

		[Token(Token = "0x400C532")]
		[FieldOffset(Offset = "0xC")]
		public string introduction;

		[Token(Token = "0x400C533")]
		[FieldOffset(Offset = "0x10")]
		public uint goPos;

		[Token(Token = "0x400C534")]
		[FieldOffset(Offset = "0x14")]
		public string subGoPos;

		[Token(Token = "0x400C535")]
		[FieldOffset(Offset = "0x18")]
		public bool prefersExternal;

		[Token(Token = "0x6009B89")]
		[Address(RVA = "0x2FB658C", Offset = "0x2FB658C", VA = "0x2FB658C")]
		public Data(uint groupId, string introduction, uint goPos, string subGoPos, bool prefersExternal)
		{
		}
	}

	[Token(Token = "0x400C52E")]
	[FieldOffset(Offset = "0x28")]
	private UIActivityIntroductionContentView m_View;

	[Token(Token = "0x400C52F")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelActivity m_ModelActivity;

	[Token(Token = "0x400C530")]
	[FieldOffset(Offset = "0x30")]
	private Data m_Data;

	[Token(Token = "0x6009B80")]
	[Address(RVA = "0x2FB5DC8", Offset = "0x2FB5DC8", VA = "0x2FB5DC8")]
	public UIActivityIntroductionContentController()
	{
	}

	[Token(Token = "0x6009B81")]
	[Address(RVA = "0x2FB5DD0", Offset = "0x2FB5DD0", VA = "0x2FB5DD0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009B82")]
	[Address(RVA = "0x2FB5E74", Offset = "0x2FB5E74", VA = "0x2FB5E74", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6009B83")]
	[Address(RVA = "0x2FB6040", Offset = "0x2FB6040", VA = "0x2FB6040", Slot = "31")]
	public override void SetData(object data)
	{
	}

	[Token(Token = "0x6009B84")]
	[Address(RVA = "0x2FB6274", Offset = "0x2FB6274", VA = "0x2FB6274")]
	public void GoTo()
	{
	}

	[Token(Token = "0x6009B85")]
	[Address(RVA = "0x2FB6488", Offset = "0x2FB6488", VA = "0x2FB6488", Slot = "32")]
	public override void Reload()
	{
	}

	[Token(Token = "0x6009B86")]
	[Address(RVA = "0x2FB6574", Offset = "0x2FB6574", VA = "0x2FB6574")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6009B87")]
	[Address(RVA = "0x2FB657C", Offset = "0x2FB657C", VA = "0x2FB657C")]
	public void _003C_003EiFixBaseProxy_SetData(object P0)
	{
	}

	[Token(Token = "0x6009B88")]
	[Address(RVA = "0x2FB6584", Offset = "0x2FB6584", VA = "0x2FB6584")]
	public void _003C_003EiFixBaseProxy_Reload()
	{
	}
}
