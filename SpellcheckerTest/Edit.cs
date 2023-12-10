namespace SpellcheckerTest
{
        public class Edit
        {
            public int Position { get; set; }  // 編集が行われた位置

            public string InsertedText { get; set; }  // 挿入されたテキスト

            public string DeletedText { get; set; }  // 削除されたテキスト
        }
}