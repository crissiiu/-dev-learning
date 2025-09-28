import { Injectable, UnauthorizedException } from '@nestjs/common';
import { UsersService } from '@/modules/users/users.service';
import { comparePasswordHelper } from '@/helpers/util';
import { access } from 'fs';
import { JwtService } from '@nestjs/jwt';

@Injectable()
export class AuthService {
  constructor(
    private usersService: UsersService,
    private jwtService: JwtService,
  ) {}

  async SignIn(username: string, pwd: string): Promise<any> {
    const user = await this.usersService.findByEmail(username);
    const isValidPassword = await comparePasswordHelper(pwd, user.password);

    if (!isValidPassword) {
      throw new UnauthorizedException('Username or password is not valid!');
    }

    const payload = { sub: user._id, username: user.email };

    return {
      access_token: await this.jwtService.signAsync(payload),
    };
  }
}
