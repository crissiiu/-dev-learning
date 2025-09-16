import { Injectable, UnauthorizedException } from '@nestjs/common';
import { UsersService } from '@/modules/users/users.service';
import { comparePasswordHelper } from '@/helpers/util';

@Injectable()
export class AuthService {
  constructor(private usersService: UsersService) {}

  async SignIn(username: string, pwd: string): Promise<any> {
    const user = await this.usersService.findByEmail(username);
    if (!comparePasswordHelper(pwd, user.password)) {
      throw new UnauthorizedException();
    }

    const { password, ...result } = user;
    return result;
  }
}
