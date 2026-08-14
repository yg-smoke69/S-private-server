using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002E49")]
public class UIManualGrownData : UIManualDataBase
{
	[Token(Token = "0x4011B18")]
	[FieldOffset(Offset = "0x38")]
	public List<LevelRewardData> m_LevelRewadList;

	[Token(Token = "0x60135DA")]
	[Address(RVA = "0x2C2497C", Offset = "0x2C2497C", VA = "0x2C2497C")]
	public UIManualGrownData()
	{
	}

	[Token(Token = "0x60135DB")]
	[Address(RVA = "0x2C24A04", Offset = "0x2C24A04", VA = "0x2C24A04", Slot = "4")]
	public override void Init()
	{
	}

	[Token(Token = "0x60135DC")]
	[Address(RVA = "0x2C24A6C", Offset = "0x2C24A6C", VA = "0x2C24A6C")]
	public void _003C_003EiFixBaseProxy_Init()
	{
	}
}
