namespace library.Models;

// One Member object holds one row of lending.member.
public class Member
{
    public long MemberId { get; set; }           // member_id BIGINT, the primary key[cite: 1]
    public string FullName { get; set; } = "";   // full_name VARCHAR(80) NOT NULL[cite: 1]
    public string? Email { get; set; }           // email VARCHAR(120), may be NULL[cite: 1]
    public string MemberType { get; set; } = ""; // member_type VARCHAR(10) NOT NULL DEFAULT 'Regular'[cite: 1]
}