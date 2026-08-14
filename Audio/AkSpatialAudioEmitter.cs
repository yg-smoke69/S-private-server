using AK.Wwise;
using Il2CppDummyDll;

[Token(Token = "0x2003E38")]
public class AkSpatialAudioEmitter : AkSpatialAudioBase
{
	[Token(Token = "0x401A56C")]
	[FieldOffset(Offset = "0x10")]
	public AuxBus reflectAuxBus;

	[Token(Token = "0x401A56D")]
	[FieldOffset(Offset = "0x14")]
	public float reflectionMaxPathLength;

	[Token(Token = "0x401A56E")]
	[FieldOffset(Offset = "0x18")]
	public float reflectionsAuxBusGain;

	[Token(Token = "0x401A56F")]
	[FieldOffset(Offset = "0x1C")]
	public uint reflectionsOrder;

	[Token(Token = "0x401A570")]
	[FieldOffset(Offset = "0x20")]
	public float roomReverbAuxBusGain;

	[Token(Token = "0x401A571")]
	[FieldOffset(Offset = "0x24")]
	public uint diffractionMaxEdges;

	[Token(Token = "0x401A572")]
	[FieldOffset(Offset = "0x28")]
	public uint diffractionMaxPaths;

	[Token(Token = "0x401A573")]
	[FieldOffset(Offset = "0x2C")]
	public uint diffractionMaxPathLength;

	[Token(Token = "0x60194BD")]
	[Address(RVA = "0x2EB6DD4", Offset = "0x2EB6DD4", VA = "0x2EB6DD4")]
	public AkSpatialAudioEmitter()
	{
	}

	[Token(Token = "0x60194BE")]
	[Address(RVA = "0x2EB6E68", Offset = "0x2EB6E68", VA = "0x2EB6E68")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x60194BF")]
	[Address(RVA = "0x2EB718C", Offset = "0x2EB718C", VA = "0x2EB718C")]
	private void OnDisable()
	{
	}
}
