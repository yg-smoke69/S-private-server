using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x200324F")]
public class UIModelSecretMessage : UIBaseModel
{
	[Token(Token = "0x2003250")]
	public enum ExchangeErrorCode
	{
		[Token(Token = "0x401322F")]
		Unknown,
		[Token(Token = "0x4013230")]
		Success,
		[Token(Token = "0x4013231")]
		ModelNotReady,
		[Token(Token = "0x4013232")]
		SeparatorNotFound,
		[Token(Token = "0x4013233")]
		SecretMessageBorderNotFound,
		[Token(Token = "0x4013234")]
		PrefixCodeNotFound,
		[Token(Token = "0x4013235")]
		SecretCodeNotFound
	}

	[Token(Token = "0x2003251")]
	private sealed class _003CRequestSecretMessageKey_003Ec__AnonStorey0
	{
		[Token(Token = "0x4013236")]
		[FieldOffset(Offset = "0x8")]
		internal uint secretMessageID;

		[Token(Token = "0x4013237")]
		[FieldOffset(Offset = "0xC")]
		internal uint activityID;

		[Token(Token = "0x4013238")]
		[FieldOffset(Offset = "0x10")]
		internal UIModelSecretMessage _0024this;

		[Token(Token = "0x6015378")]
		[Address(RVA = "0x30E3720", Offset = "0x30E3720", VA = "0x30E3720")]
		public _003CRequestSecretMessageKey_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6015379")]
		[Address(RVA = "0x30E5010", Offset = "0x30E5010", VA = "0x30E5010")]
		internal void _003C_003Em__0(HttpErrorCode errorCode, object result)
		{
		}
	}

	[Token(Token = "0x4013228")]
	public const char SECRET_MESSAGE_SEPARATOR = '@';

	[Token(Token = "0x4013229")]
	public const uint PropID_SecretMessageDescReceived = 1u;

	[Token(Token = "0x401322A")]
	public const uint PropID_SecretMessageReceived = 2u;

	[Token(Token = "0x401322B")]
	public const uint PropID_SecretMessageExchanged = 4u;

	[Token(Token = "0x401322C")]
	[FieldOffset(Offset = "0xC")]
	private readonly WaitingResponseHandler m_WaitingResponseHandler;

	[Token(Token = "0x401322D")]
	[FieldOffset(Offset = "0x10")]
	private List<SecretMissionDesc> m_SecretMessageDescList;

	[Token(Token = "0x17001658")]
	private bool IsReady
	{
		[Token(Token = "0x6015361")]
		[Address(RVA = "0x30E2D68", Offset = "0x30E2D68", VA = "0x30E2D68")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6015360")]
	[Address(RVA = "0x30E2CC0", Offset = "0x30E2CC0", VA = "0x30E2CC0")]
	public UIModelSecretMessage()
	{
	}

	[Token(Token = "0x6015362")]
	[Address(RVA = "0x30E2DCC", Offset = "0x30E2DCC", VA = "0x30E2DCC", Slot = "6")]
	public override uint GetModelType()
	{
		return default(uint);
	}

	[Token(Token = "0x6015363")]
	[Address(RVA = "0x30E2E24", Offset = "0x30E2E24", VA = "0x30E2E24", Slot = "4")]
	public override void Init()
	{
	}

	[Token(Token = "0x6015364")]
	[Address(RVA = "0x30E2E88", Offset = "0x30E2E88", VA = "0x30E2E88", Slot = "11")]
	protected override void OnCleanup()
	{
	}

	[Token(Token = "0x6015365")]
	[Address(RVA = "0x30E2EEC", Offset = "0x30E2EEC", VA = "0x30E2EEC", Slot = "9")]
	public override void Logout(object[] data)
	{
	}

	[Token(Token = "0x6015366")]
	[Address(RVA = "0x30E2FC0", Offset = "0x30E2FC0", VA = "0x30E2FC0")]
	public void RequestSecretMessageDesc()
	{
	}

	[Token(Token = "0x6015367")]
	[Address(RVA = "0x30E31E8", Offset = "0x30E31E8", VA = "0x30E31E8")]
	private void OnRequestSecretMessageDescFinished(HttpErrorCode errorCode, object result)
	{
	}

	[Token(Token = "0x6015368")]
	[Address(RVA = "0x30E33CC", Offset = "0x30E33CC", VA = "0x30E33CC")]
	public void RequestSecretMessageKey(uint activityID)
	{
	}

	[Token(Token = "0x6015369")]
	[Address(RVA = "0x30E39A8", Offset = "0x30E39A8", VA = "0x30E39A8")]
	public void RequestExchangeSecretMessageKey(uint secretMissionID, ulong suffixCode)
	{
	}

	[Token(Token = "0x601536A")]
	[Address(RVA = "0x30E3D20", Offset = "0x30E3D20", VA = "0x30E3D20")]
	private void OnRequestExchangeSecretMessageKey(HttpErrorCode errorCode, object result)
	{
	}

	[Token(Token = "0x601536B")]
	[Address(RVA = "0x30E3728", Offset = "0x30E3728", VA = "0x30E3728")]
	private uint GetSecretMessageIDWithActivityIDInternal(uint activityID)
	{
		return default(uint);
	}

	[Token(Token = "0x601536C")]
	[Address(RVA = "0x30E3F2C", Offset = "0x30E3F2C", VA = "0x30E3F2C")]
	private SecretMissionDesc GetSecretMessageDescWithIDInternal(uint secretMessageID)
	{
		return null;
	}

	[Token(Token = "0x601536D")]
	[Address(RVA = "0x30E40E0", Offset = "0x30E40E0", VA = "0x30E40E0")]
	public static string GetSecretMessageContent(string prefixKey, ulong secretCode)
	{
		return null;
	}

	[Token(Token = "0x601536E")]
	[Address(RVA = "0x30E42B8", Offset = "0x30E42B8", VA = "0x30E42B8")]
	public bool IsSystemAvailable()
	{
		return default(bool);
	}

	[Token(Token = "0x601536F")]
	[Address(RVA = "0x30E4318", Offset = "0x30E4318", VA = "0x30E4318")]
	public uint GetSecretMessageIDWithActivityID(uint activityID)
	{
		return default(uint);
	}

	[Token(Token = "0x6015370")]
	[Address(RVA = "0x30E4384", Offset = "0x30E4384", VA = "0x30E4384")]
	public uint GetSecretMessageExchangeLimit(uint secretMessageID)
	{
		return default(uint);
	}

	[Token(Token = "0x6015371")]
	[Address(RVA = "0x30E4410", Offset = "0x30E4410", VA = "0x30E4410")]
	public string GetSecretMessageTitleKey(uint secretMessageID)
	{
		return null;
	}

	[Token(Token = "0x6015372")]
	[Address(RVA = "0x30E4554", Offset = "0x30E4554", VA = "0x30E4554")]
	public string GetSecretMessageAdditionalKey(uint secretMessageID)
	{
		return null;
	}

	[Token(Token = "0x6015373")]
	[Address(RVA = "0x30E4698", Offset = "0x30E4698", VA = "0x30E4698")]
	public string GetSecretMessageCompleteContent(uint secretMessageID, string secretMessageContent)
	{
		return null;
	}

	[Token(Token = "0x6015374")]
	[Address(RVA = "0x30E4A58", Offset = "0x30E4A58", VA = "0x30E4A58")]
	public ExchangeErrorCode TryExchangeSecretMessageWithRawContent(uint secretMessageID, string rawContent)
	{
		return default(ExchangeErrorCode);
	}

	[Token(Token = "0x6015375")]
	[Address(RVA = "0x30E4FF8", Offset = "0x30E4FF8", VA = "0x30E4FF8")]
	public void _003C_003EiFixBaseProxy_Init()
	{
	}

	[Token(Token = "0x6015376")]
	[Address(RVA = "0x30E5000", Offset = "0x30E5000", VA = "0x30E5000")]
	public void _003C_003EiFixBaseProxy_OnCleanup()
	{
	}

	[Token(Token = "0x6015377")]
	[Address(RVA = "0x30E5008", Offset = "0x30E5008", VA = "0x30E5008")]
	public void _003C_003EiFixBaseProxy_Logout(object[] P0)
	{
	}
}
