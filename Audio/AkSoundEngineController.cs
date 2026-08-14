using Il2CppDummyDll;

[Token(Token = "0x2003E36")]
public class AkSoundEngineController
{
	[Token(Token = "0x401A56A")]
	[FieldOffset(Offset = "0x0")]
	private static AkSoundEngineController ms_Instance;

	[Token(Token = "0x17001B99")]
	public static AkSoundEngineController Instance
	{
		[Token(Token = "0x60194AD")]
		[Address(RVA = "0x46B6078", Offset = "0x46B6078", VA = "0x46B6078")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60194AC")]
	[Address(RVA = "0x46B6070", Offset = "0x46B6070", VA = "0x46B6070")]
	private AkSoundEngineController()
	{
	}

	[Token(Token = "0x60194AE")]
	[Address(RVA = "0x46B6118", Offset = "0x46B6118", VA = "0x46B6118", Slot = "1")]
	~AkSoundEngineController()
	{
	}

	[Token(Token = "0x60194AF")]
	[Address(RVA = "0x46B6194", Offset = "0x46B6194", VA = "0x46B6194")]
	public static string GetDecodedBankFolder()
	{
		return null;
	}

	[Token(Token = "0x60194B0")]
	[Address(RVA = "0x46B61F0", Offset = "0x46B61F0", VA = "0x46B61F0")]
	public static string GetDecodedBankFullPath()
	{
		return null;
	}

	[Token(Token = "0x60194B1")]
	[Address(RVA = "0x46B62CC", Offset = "0x46B62CC", VA = "0x46B62CC")]
	public void LateUpdate()
	{
	}

	[Token(Token = "0x60194B2")]
	[Address(RVA = "0x46B63E4", Offset = "0x46B63E4", VA = "0x46B63E4")]
	public void Init(AkInitializer akInitializer)
	{
	}

	[Token(Token = "0x60194B3")]
	[Address(RVA = "0x46B65CC", Offset = "0x46B65CC", VA = "0x46B65CC")]
	public void OnDisable()
	{
	}

	[Token(Token = "0x60194B4")]
	[Address(RVA = "0x46B65D0", Offset = "0x46B65D0", VA = "0x46B65D0")]
	public void Terminate()
	{
	}

	[Token(Token = "0x60194B5")]
	[Address(RVA = "0x46B664C", Offset = "0x46B664C", VA = "0x46B664C")]
	public void OnApplicationPause(bool pauseStatus)
	{
	}

	[Token(Token = "0x60194B6")]
	[Address(RVA = "0x46B6780", Offset = "0x46B6780", VA = "0x46B6780")]
	public void OnApplicationFocus(bool focus)
	{
	}

	[Token(Token = "0x60194B7")]
	[Address(RVA = "0x46B6658", Offset = "0x46B6658", VA = "0x46B6658")]
	private void ActivateAudio(bool activate, bool renderAnyway = false)
	{
	}
}
