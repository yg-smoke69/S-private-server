using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace PrefabEvolution;

[Serializable]
[Token(Token = "0x2003BA7")]
public class ExposedPropertyGroup : BaseExposedData
{
	[Token(Token = "0x401966E")]
	[FieldOffset(Offset = "0x0")]
	public static Dictionary<int, bool> expandedDict;

	[Token(Token = "0x401966F")]
	[FieldOffset(Offset = "0x1C")]
	private bool expandedLoaded;

	[Token(Token = "0x4019670")]
	[FieldOffset(Offset = "0x1D")]
	private bool expanded;

	[Token(Token = "0x170018B4")]
	public bool Expanded
	{
		[Token(Token = "0x6017CE5")]
		[Address(RVA = "0x1E2C5DC", Offset = "0x1E2C5DC", VA = "0x1E2C5DC")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6017CE6")]
		[Address(RVA = "0x1E2C6C4", Offset = "0x1E2C6C4", VA = "0x1E2C6C4")]
		set
		{
		}
	}

	[Token(Token = "0x6017CE4")]
	[Address(RVA = "0x1E2C5D0", Offset = "0x1E2C5D0", VA = "0x1E2C5D0")]
	public ExposedPropertyGroup()
	{
	}
}
