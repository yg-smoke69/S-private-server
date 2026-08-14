using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20000C6")]
public class BigHeadDataConfig
{
	[Token(Token = "0x40004BB")]
	[FieldOffset(Offset = "0x8")]
	private List<BigHeadData> m_DataList;

	[Token(Token = "0x6000572")]
	[Address(RVA = "0x1809E40", Offset = "0x1809E40", VA = "0x1809E40")]
	public BigHeadDataConfig(List<BigHeadData> list)
	{
	}

	[Token(Token = "0x6000573")]
	[Address(RVA = "0x1809E60", Offset = "0x1809E60", VA = "0x1809E60")]
	public BigHeadData GetData(int level)
	{
		return null;
	}

	[Token(Token = "0x6000574")]
	[Address(RVA = "0x1809F68", Offset = "0x1809F68", VA = "0x1809F68")]
	public float GetHeadShotDamageScale(int level)
	{
		return default(float);
	}

	[Token(Token = "0x6000575")]
	[Address(RVA = "0x1809FE4", Offset = "0x1809FE4", VA = "0x1809FE4")]
	public float GetHeadScale(int level)
	{
		return default(float);
	}
}
