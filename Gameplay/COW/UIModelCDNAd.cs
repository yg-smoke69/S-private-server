using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002EFC")]
public class UIModelCDNAd : UIBaseModel
{
	[Token(Token = "0x4011F67")]
	[FieldOffset(Offset = "0xC")]
	private Dictionary<uint, List<AdvertDesc>> m_AdDic;

	[Token(Token = "0x6013ABD")]
	[Address(RVA = "0x32C8F54", Offset = "0x32C8F54", VA = "0x32C8F54")]
	public UIModelCDNAd()
	{
	}

	[Token(Token = "0x6013ABE")]
	[Address(RVA = "0x32C900C", Offset = "0x32C900C", VA = "0x32C900C", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x6013ABF")]
	[Address(RVA = "0x32C9064", Offset = "0x32C9064", VA = "0x32C9064")]
	public void ProcessCDNAd(CSGetAdvertRes adRes)
	{
	}

	[Token(Token = "0x6013AC0")]
	[Address(RVA = "0x32C93D8", Offset = "0x32C93D8", VA = "0x32C93D8")]
	public List<AdvertDesc> GetAdList(AdType type)
	{
		return null;
	}

	[Token(Token = "0x6013AC1")]
	[Address(RVA = "0x32C9518", Offset = "0x32C9518", VA = "0x32C9518", Slot = "8")]
	public override void Login(object[] data)
	{
	}

	[Token(Token = "0x6013AC2")]
	[Address(RVA = "0x32C9588", Offset = "0x32C9588", VA = "0x32C9588", Slot = "9")]
	public override void Logout(object[] data)
	{
	}

	[Token(Token = "0x6013AC3")]
	[Address(RVA = "0x32C9660", Offset = "0x32C9660", VA = "0x32C9660")]
	public void _003C_003EiFixBaseProxy_Login(object[] P0)
	{
	}

	[Token(Token = "0x6013AC4")]
	[Address(RVA = "0x32C9668", Offset = "0x32C9668", VA = "0x32C9668")]
	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
