using Il2CppDummyDll;

namespace GCommon;

[Token(Token = "0x2003EEC")]
public class InjectFixManager
{
	[Token(Token = "0x401A944")]
	[FieldOffset(Offset = "0x0")]
	private static InjectFixManager instance;

	[Token(Token = "0x401A945")]
	[FieldOffset(Offset = "0x8")]
	public bool LoadPatchFailed;

	[Token(Token = "0x17001BFD")]
	public static InjectFixManager Instance
	{
		[Token(Token = "0x6019A1B")]
		[Address(RVA = "0x32BC05C", Offset = "0x32BC05C", VA = "0x32BC05C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6019A1A")]
	[Address(RVA = "0x32BC054", Offset = "0x32BC054", VA = "0x32BC054")]
	public InjectFixManager()
	{
	}

	[Token(Token = "0x6019A1C")]
	[Address(RVA = "0x32BC0FC", Offset = "0x32BC0FC", VA = "0x32BC0FC")]
	public void LoadPatch(ResourceID[] codePatchResIDs)
	{
	}
}
