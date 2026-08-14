using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002E60")]
public class UIModeEditDataManager : SingletonModule<UIModeEditDataManager>
{
	[Token(Token = "0x4011B74")]
	[FieldOffset(Offset = "0xC")]
	public Dictionary<string, IModeEditComponentData> BindVariablesUIMapping;

	[Token(Token = "0x601364C")]
	[Address(RVA = "0x1309DF4", Offset = "0x1309DF4", VA = "0x1309DF4")]
	public UIModeEditDataManager()
	{
	}

	[Token(Token = "0x601364D")]
	[Address(RVA = "0x1309EB8", Offset = "0x1309EB8", VA = "0x1309EB8", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x601364E")]
	[Address(RVA = "0x1309F0C", Offset = "0x1309F0C", VA = "0x1309F0C", Slot = "7")]
	protected override void OnCleanup()
	{
	}
}
