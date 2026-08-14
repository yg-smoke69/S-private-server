using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002E07")]
internal class PCServerConfigDataManager : SingletonModule<PCServerConfigDataManager>
{
	[Token(Token = "0x4011A19")]
	private const string overrideFileName = "serverList.json";

	[Token(Token = "0x4011A1A")]
	[FieldOffset(Offset = "0xC")]
	private ServerListConfig m_ServerListConfig;

	[Token(Token = "0x170013FB")]
	public ServerListConfig ServerListConfig
	{
		[Token(Token = "0x6013481")]
		[Address(RVA = "0x28CD6F0", Offset = "0x28CD6F0", VA = "0x28CD6F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6013480")]
	[Address(RVA = "0x28CD660", Offset = "0x28CD660", VA = "0x28CD660")]
	public PCServerConfigDataManager()
	{
	}

	[Token(Token = "0x6013482")]
	[Address(RVA = "0x28CD748", Offset = "0x28CD748", VA = "0x28CD748", Slot = "6")]
	protected override void OnInit()
	{
	}

	[Token(Token = "0x6013483")]
	[Address(RVA = "0x28CDB00", Offset = "0x28CDB00", VA = "0x28CDB00")]
	public void OverrideGameConfig(object data)
	{
	}

	[Token(Token = "0x6013484")]
	[Address(RVA = "0x28CDD98", Offset = "0x28CDD98", VA = "0x28CDD98", Slot = "7")]
	protected override void OnCleanup()
	{
	}
}
