using System;
using Il2CppDummyDll;

[Token(Token = "0x200417D")]
public sealed class AssetReference : Attribute
{
	[Token(Token = "0x401B75E")]
	[FieldOffset(Offset = "0x8")]
	private AssetRefType _003CRefType_003Ek__BackingField;

	[Token(Token = "0x17001D7E")]
	public AssetRefType RefType
	{
		[Token(Token = "0x601AC18")]
		[Address(RVA = "0x2ECD984", Offset = "0x2ECD984", VA = "0x2ECD984")]
		get
		{
			return default(AssetRefType);
		}
		[Token(Token = "0x601AC19")]
		[Address(RVA = "0x2ECD97C", Offset = "0x2ECD97C", VA = "0x2ECD97C")]
		private set
		{
		}
	}

	[Token(Token = "0x601AC17")]
	[Address(RVA = "0x2ECD95C", Offset = "0x2ECD95C", VA = "0x2ECD95C")]
	public AssetReference(AssetRefType refType)
	{
	}
}
