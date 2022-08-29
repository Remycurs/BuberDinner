namespace BuberDinner.Contrasts.Authentication;

public record LoginRequest
(
    string Email,
    string Password
);